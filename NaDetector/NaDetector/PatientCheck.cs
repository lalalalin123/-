using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using AxTeeChart;
using System.Threading;
using PetDetector.classUnity;
using Microsoft.Win32;
using System.Diagnostics;

namespace PetDetector
{
    public partial class PatientCheck : Form
    {
        byte[] AllByte = null;                         //串口接收到的字节数组
        int Index;                                  //串口接收数据索引
        OperatorFile op = new OperatorFile();       //对setting.ini文件进行读写操作类
        Patient patient;
        private byte bookByte = 0x30;
        //串口
        double num;   //接收到的Na离子浓度值
        double iid = 0;//曲线横坐标  递增
        byte[] part;
        List<double> receiveData = new List<double>();
        Dictionary<int, Point> order = new Dictionary<int, Point>();//曲线标号
        int workStatus = 0;  //0为停止，1为工作中，2为暂停
        private string hospital;
        private double JingShi = 0;
        private double k = 0, b1 = 0;
        private List<double> Warning = new List<double>();
        public PatientCheck()
        {
            InitializeComponent();
        }

        private void PetCheck_Load(object sender, EventArgs e)
        {
            //只允许有一个进程存在
            Process[] processes = Process.GetProcessesByName("NaDetector");
            if(processes.Count() > 1)
            {
                Environment.Exit(0);
            }

            if (SqlDeal.ifTableExist())
            {
                int id = SqlDeal.getID();
                if(id >= 2000)
                {
                    MessageBox.Show("系统内存已满！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    Thread.Sleep(1000);
                    Environment.Exit(0);          
                }
                else
                {
                    id = id + 1;
                    SqlDeal.setID(id);
                }
            }
            else
            {
                SqlDeal.createTable();
            }

            hospital = OperatorFile.GetIniFileString("patientCheck", "name", "", Application.StartupPath + "\\setting.ini");
            label1.Text = "钠离子检测(" + hospital + ")";

            try
            {                    
                int temp1 = int.Parse(OperatorFile.GetIniFileString("patientCheck", "bookByte", "", Application.StartupPath + "\\setting.ini"));
                JingShi = double.Parse(OperatorFile.GetIniFileString("patientCheck", "JingShi", "", Application.StartupPath + "\\setting.ini"));
                textBox1.Text = JingShi.ToString();
                k = double.Parse(OperatorFile.GetIniFileString("patientCheck", "k", "", Application.StartupPath + "\\setting.ini"));
                b1 = double.Parse(OperatorFile.GetIniFileString("patientCheck", "b", "", Application.StartupPath + "\\setting.ini"));
                byte.TryParse(temp1.ToString(), out bookByte);
            }
            catch
            {
                throw new Exception("获取初始化数据错误");
            }

            //图标显示控件设定
            axTChart1.Legend.DividingLines.Visible = true;
            axTChart1.Environment.MouseWheelScroll = false;//取消鼠标滚轮滑动
            axTChart1.Scroll.Enable = TeeChart.EChartScroll.pmHorizontal;
            axTChart1.Scroll.MouseButton = TeeChart.EMouseButton.mbRight;
            axTChart1.Zoom.Enable = true ;
            //for (int i = 0; i < 1000; i++)
            //    Warning.Add(JingShi);
            //axTChart1.Invoke((EventHandler)(delegate
            //{
            //    axTChart1.Series(0).AddArray(5000, Warning.ToArray());              
            //}));
            resetWarning();
            drawWarningLine();
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            for (int i=1;i<21;i++)
            {
                toolStripComboBox1.Items.Add(i.ToString());
            }

            part = new byte[1];
            string com = "";
            try
            {
                com = OperatorFile.GetIniFileString("patientCheck", "port", "", Application.StartupPath+"\\setting.ini");
                serialPort1.PortName = com;
                serialPort1.Open();            
            }
            catch
            {
                MessageBox.Show(com + "串口打开失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (serialPort1.IsOpen)
                    serialPort1.Close();
            }

            this.BackColor = Color.FromArgb(173, 220, 250);
            disEnable(btnStop);

            try//创建文件夹
            {
                CreateDirectory("word");//？：为什么要用静态类和实例类各创建一次
                CreateDirectory("pdf");
                CreateDirectory("picture");              
            }
            catch
            {
                MessageBox.Show("文件夹创建失败，请手动创建！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //接收数据处理数据
            Index = 0;
            AllByte = new byte[1];//串口接收到的字节数组
            byte[] receive = new byte[1000];
            int all = serialPort1.Read(receive, 0, receive.Length);

            AllByte = new byte[all + part.Length];
            Array.Copy(part, AllByte, part.Length);
            Array.Copy(receive, 0, AllByte, part.Length, all);

            if (AllByte.Length > 6)
            {
                for (; Index < AllByte.Length - 6; Index++)
                {
                    if (AllByte[Index] == 0x24 && AllByte[Index + 1] == 0x24 && AllByte[Index + 5] == 0x0d && AllByte[Index + 6] == 0x0a)//帧头、帧尾校验
                    {
                        if (AllByte[Index + 4] == (AllByte[Index + 2] ^ AllByte[Index + 3]))//数据有效性校验
                        {
                            num = (double)(AllByte[Index + 2] * 256 + AllByte[Index + 3]) / 100;//NA离子浓度
                            num = k * num + b1;
                            num = Math.Round(num, 2);//保留两位小数                       

                            if (WorkStatus == 1||workStatus==2)//工作状态或硬件检测状态
                            {
                                if(workStatus == 2)
                                    axTChart1.Series(1).asLine.LinePen.Width = 4;
                                else
                                    axTChart1.Series(1).asLine.LinePen.Width = 2;
                                receiveData.Add(num);
                                iid++;
                                if (num <= JingShi)
                                    axTChart1.Invoke((EventHandler)(delegate
                                    {
                                        axTChart1.Series(1).AddXY(iid, num, iid.ToString(), 16711680);//第四个参数为颜色
                                    }));
                                else
                                    axTChart1.Invoke((EventHandler)(delegate
                                    {
                                        axTChart1.Series(1).AddXY(iid, num, iid.ToString(), 16711935);
                                    }));
                                label6.Invoke((EventHandler)(delegate
                                {
                                    label6.Text = num.ToString("0.00");
                                }));                   
                                if (iid > Warning.Count)//警示线
                                {
                                    //for (int i = Warning.Count; i < Warning.Count + 1000; i++)
                                    for (int i = 0; i < 1000; i++)
                                        Warning.Add(JingShi);//再加1000个点                                          
                                    drawWarningLine();
                                    //axTChart1.Invoke((EventHandler)(delegate
                                    //{
                                    //    axTChart1.Series(0).AddArray(Warning.Count, Warning.ToArray());
                                    //}));
                                }
                                if (iid >= axTChart1.Axis.Bottom.Maximum - 10)
                                    axTChart1.Invoke((EventHandler)(delegate
                                    {
                                        axTChart1.Axis.Bottom.Scroll(1, true);
                                    }));
                            }
                            Index += 5;
                        }
                    }
                    else if(AllByte[Index] == 0x24 && AllByte[Index + 1] == 0x24 && AllByte[Index + 4] == 0x0d && AllByte[Index + 5] == 0x0a)
                    {
                        num = (double)(AllByte[Index + 2] * 256 + AllByte[Index + 3]) / 100;//NA离子浓度
                        num = k * num + b1;
                        num = Math.Round(num, 2);//保留两位小数

                        if (WorkStatus == 1 || workStatus == 2)//工作状态或硬件检测状态
                        {
                            if (workStatus == 2)
                                axTChart1.Series(1).asLine.LinePen.Width = 4;
                            else
                                axTChart1.Series(1).asLine.LinePen.Width = 2;
                            receiveData.Add(num);
                            iid++;
                            if (num <= JingShi)
                                axTChart1.Invoke((EventHandler)(delegate
                                {
                                    axTChart1.Series(1).AddXY(iid, num, iid.ToString(), 16711680);//第四个参数为颜色
                                }));
                            else
                                axTChart1.Invoke((EventHandler)(delegate
                                {
                                    axTChart1.Series(1).AddXY(iid, num, iid.ToString(), 16711935);
                                }));
                            label6.Invoke((EventHandler)(delegate
                            {
                                label6.Text = num.ToString("0.00");
                            }));
                            if (iid > Warning.Count)
                            {
                                for (int i = 0; i < 1000; i++)
                                    Warning.Add(JingShi);//再加1000个点
                                drawWarningLine();
                                //axTChart1.Invoke((EventHandler)(delegate
                                //{
                                //    axTChart1.Series(0).AddArray(Warning.Count, Warning.ToArray());
                                //}));
                            }
                            if (iid >= axTChart1.Axis.Bottom.Maximum - 10)
                                axTChart1.Invoke((EventHandler)(delegate
                                {
                                    axTChart1.Axis.Bottom.Scroll(1, true);
                                }));
                        }
                        Index += 4;
                    }
                }
                part = new byte[AllByte.Length - Index];
                Array.Copy(AllByte, Index, part, 0, AllByte.Length - Index);//保存帧尾
            }
            else
            {
                part = new byte[AllByte.Length];
                Array.Copy(AllByte, part, AllByte.Length);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("病人姓名不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtHospitalNumber.Text))
            {
                MessageBox.Show("住院号不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtBedNumber.Text))
            {
                MessageBox.Show("床号不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtCategory.Text))
            {
                MessageBox.Show("科别不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (cbSex.SelectedIndex < 0)
            {
                MessageBox.Show("性别不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (SqlDeal.checkNumberExist(txtHospitalNumber.Text))
            {
                MessageBox.Show("该住院号已存在，请更换", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            patient = getPatient();
            try
            {
                SqlDeal.saveData(patient);
                Enable(btnAdd);
                disEnable(btnSave);
            }
            catch
            {
                MessageBox.Show("保存失败", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnQuary_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHospitalNumber.Text))
            {
                MessageBox.Show("住院号不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!SqlDeal.checkNumberExist(txtHospitalNumber.Text))
            {
                MessageBox.Show("住院号不存在", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                clearAllInput();
                clearOrder();
                return;
            }
            try
            {
                DataTable table = SqlDeal.getPatientByHospitalNumber(txtHospitalNumber.Text);

                txtName.Text = table.Rows[0]["name"].ToString();
                txtHospitalNumber.Text = table.Rows[0]["hospitalnumber"].ToString();
                txtAge.Text = table.Rows[0]["age"].ToString();
                cbSex.Text = table.Rows[0]["sex"].ToString();
                txtCategory.Text = table.Rows[0]["category"].ToString();
                txtBedNumber.Text = table.Rows[0]["bednumber"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(table.Rows[0]["time"].ToString());
                rtxtRemark.Text = table.Rows[0]["remark"].ToString();
            }
            catch
            {
                MessageBox.Show("查询失败", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                clearAllInput();
                clearOrder();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "开  始(S)")
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("病人姓名不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtHospitalNumber.Text))
                {
                    MessageBox.Show("住院号不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtBedNumber.Text))
                {
                    MessageBox.Show("床号不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtCategory.Text))
                {
                    MessageBox.Show("科别不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (cbSex.SelectedIndex < 0)
                {
                    MessageBox.Show("性别不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (!SqlDeal.checkNumberExist(txtHospitalNumber.Text))
                {
                    MessageBox.Show("该住院号不存在，请更换", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                dateTimePicker1.Value = DateTime.Now;
                if (SqlDeal.ifChecked(txtHospitalNumber.Text))
                {
                    if (MessageBox.Show("该病人已检测过，继续检测将覆盖原有数据，是否继续？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                string com = "";
                try
                {
                    com = OperatorFile.GetIniFileString("patientCheck", "port", "", Application.StartupPath + "\\setting.ini");
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.PortName = com;
                        serialPort1.Open();
                    }
                }
                catch
                {
                    MessageBox.Show(com + "串口打开失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (serialPort1.IsOpen)
                        serialPort1.Close();
                    return;
                }

                btnStart.Text = "暂  停(P)";
                if (serialPort1.IsOpen)
                {
                    //发送获取数据指令
                    sendTo();
                }
                else
                {
                    serialPort1.Open();
                    sendTo();
                }

                receiveData.Clear();
                WorkStatus = 1;
            }
            else if(btnStart.Text == "暂  停(P)")
            {
                btnStart.Text = "继  续(C)";
                WorkStatus = 3;
            }
            else if(btnStart.Text == "继  续(C)")
            {
                btnStart.Text = "暂  停(P)";
                WorkStatus = 1;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认结束？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;
            try
            {
                WorkStatus = 0;
                btnStart.Text = "开  始(S)";
                string path = Application.StartupPath + @"\picture\" + txtHospitalNumber.Text + " " + txtName.Text + ".jpg";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                axTChart1.Export.asJPEG.SaveToFile(path);

                if (receiveData.Count > 0)
                {
                    //更新患者数据
                    patient = getPatient(path);
                    SqlDeal.updateData(patient);                  
                    toolUnity.Tool.exportWord(patient);              
                }
                else
                {
                    if (MessageBox.Show("未接收有效数据，是否继续保存？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        //更新患者数据
                        patient = getPatient(path);
                        SqlDeal.updateData(patient);
                        toolUnity.Tool.exportWord(patient);
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("保存失败", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            receiveData.Clear();
            resetWarning();
            clearAllInput();
            clearOrder();
            iid = 0;
            sendStop();
        }

        MD5 md5 = new MD5();

        /// <summary>
        /// 发送给硬件特定指令
        /// </summary>
        public void sendTo()
        {
            byte[] temp = md5.getRandomInteger();
            char[] charTem = YiHuo(temp, bookByte);
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(charTem, 0, charTem.Length);
            }
        }

        private void clearAllInput()
        {
            txtHospitalNumber.Text = "";
            txtName.Text = "";
            txtBedNumber.Text = "";
            txtAge.Text = "";
            txtCategory.Text = "";
            cbSex.SelectedIndex = -1;
            rtxtRemark.Text = "";
            axTChart1.Series(0).Clear();
            axTChart1.Series(1).Clear();
            axTChart1.Series(2).Clear();
            axTChart1.Series(3).Clear();
            axTChart1.Series(4).Clear();
            axTChart1.Series(5).Clear();
            axTChart1.Axis.Bottom.Minimum = 0;
            axTChart1.Axis.Bottom.Maximum = 200;
            //axTChart1.Series(0).AddArray(5000, Warning.ToArray());
            drawWarningLine();
            axTChart1.Refresh();
        }

        private Patient getPatient(string path)
        {
            Patient p = new classUnity.Patient();
            p.name = txtName.Text;
            p.age = Convert.ToInt16(txtAge.Text);
            p.sex = cbSex.Text;
            p.hostipalNumber = txtHospitalNumber.Text;
            p.cateGory = txtCategory.Text;
            p.bedNumber = txtBedNumber.Text;
            p.jingshi = double.Parse(textBox1.Text);
            p.dateTime = DateTime.Now;
            p.picturePath = path;
            p.receiveData = receiveData.ToArray();
            p.sequence = order.Keys.ToArray();
            p.coordinate = order.Values.ToArray();              
            p.remark = rtxtRemark.Text;
            p.ifChecked = true;
            return p;
        }

        private Patient getPatient()
        {
            Patient p = new classUnity.Patient();
            p.name = txtName.Text;
            p.age = Convert.ToInt16(txtAge.Text);
            p.sex = cbSex.Text;
            p.hostipalNumber = txtHospitalNumber.Text;
            p.cateGory = txtCategory.Text;
            p.bedNumber = txtBedNumber.Text;
            p.remark = rtxtRemark.Text;
            p.ifChecked = false;
            p.dateTime = DateTime.Now;
            return p;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (patient != null && patient.ifChecked)
                toolUnity.Tool.printWord(patient);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            new AllPatients().ShowDialog();
        }

        private void PetCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定关闭？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
                {
                    sendStop();
                    Application.DoEvents();
                    Environment.Exit(0);
                }
                else
                    e.Cancel = true;
            }
            catch
            {
                Application.DoEvents();
                Environment.Exit(0);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "硬件测试")
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {                        
                        sendTo();
                        receiveData.Clear();
                        timer2.Enabled = true;
                    }
                    else
                    {                      
                        serialPort1.Open();
                        sendTo();
                        receiveData.Clear();
                        timer2.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("串口打开失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (serialPort1.IsOpen)
                        serialPort1.Close();
                    return;
                }
                (sender as Button).Text = "停止测试";
                (sender as Button).BackColor = Color.FromArgb(110, 255, 255);
                Thread.Sleep(100);
                WorkStatus = 2;
            }
            else
            {
                sendStop();
                timer2.Enabled = false;           
                (sender as Button).Text = "硬件测试";
                (sender as Button).BackColor = Color.FromArgb(192, 255, 255);
                iid = 0;
                WorkStatus = 0;
                receiveData.Clear();
                resetWarning();
                axTChart1.Axis.Bottom.Minimum = 0;
                axTChart1.Axis.Bottom.Maximum = 200;
                axTChart1.Series(1).Clear();
                axTChart1.Series(2).Clear();
                clearOrder();
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定关闭？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
                {
                    sendStop();
                    Application.DoEvents();
                    Environment.Exit(0);
                }
                else
                    return;
            }
            catch
            {
                Application.DoEvents();
                Environment.Exit(0);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (receiveData.Count == 0)
            {
                if("1".Equals(timer2.Tag))
                {
                    timer2.Tag = "0";
                    sendTo();
                }   
                else
                {
                    timer2.Enabled = false;
                    timer2.Tag = "1";
                    MessageBox.Show("无数据传输！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                        
            }
            else
            {
                timer2.Tag = "1";
                timer2.Enabled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 1 && e.KeyChar != 3 && e.KeyChar != 22 && e.KeyChar != 46)
            {
                MessageBox.Show("请输入数字!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private char[] YiHuo(byte[] data, int temp)
        {
            byte b = Convert.ToByte(temp);
            byte[] a = new byte[15];
            a[0] = a[1] = 0x24;
            a[13] = 0x0D;
            a[14] = 0x0A;
            for (int i = 0; i < 5; i++)
                a[i + 8] = Convert.ToByte(data[i] ^ b);
            a[7] = bookByte;
            data.CopyTo(a, 2);
            char[] chars = Encoding.ASCII.GetChars(a);
            return chars;
        }

        /// <summary>
        /// 判断目录是否存在
        /// </summary>
        /// <param name="HKLM_SOFT_Dir_Name">HKLM\SOFTWARE下是否存在该子项</param>
        /// <returns>true or false</returns>
        public bool IsRegeditDirExist(String HKLM_SOFT_Dir_Name)
        {
            bool _exit = false;
            string[] subkeyNames;
            RegistryKey hklm = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            subkeyNames = hklm.GetSubKeyNames();
            foreach (string DirName in subkeyNames)
            {
                if (DirName == HKLM_SOFT_Dir_Name)
                {
                    _exit = true;
                    return _exit;
                }
            }
            return _exit;
        }

        private void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
            DirectoryInfo dir = new DirectoryInfo(path);
            dir.Create();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrEmpty(textBox1.Text)) 
            {
                textBox1.Invoke((EventHandler)(delegate { textBox1.Text = JingShi.ToString(); }));
                MessageBox.Show("警示值不能为空！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                JingShi = double.Parse(textBox1.Text);
                OperatorFile.WriteIniData("patientCheck", "JingShi", JingShi.ToString(), Application.StartupPath + "\\setting.ini");
                if (Warning.Count > 0)
                {
                    int temp = Warning.Count;
                    for (int i = (int)iid; i < iid + 1000; i++)
                    {
                        if (i < temp)
                            Warning[i] = JingShi;
                        else
                            Warning.Add(JingShi);
                    }
                    axTChart1.Series(0).Clear();
                    axTChart1.Series(4).Clear();
                    axTChart1.Series(5).Clear();
                    drawWarningLine();
                    //axTChart1.Invoke((EventHandler)(delegate
                    //{
                    //    axTChart1.Series(0).Clear();
                    //    axTChart1.Series(0).AddArray(Warning.Count, Warning.ToArray());
                    //}));
                }
            }
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axTChart1.Invoke((EventHandler)(delegate
            {
                if (axTChart1.Series(1).Count != 0||axTChart1.Series(2).Count !=0)
                {
                    receiveData.Clear();
                    Warning.Clear();
                    num = iid = 0;
                    for (int i = 0; i < 1000; i++)
                        Warning.Add(JingShi);
                    axTChart1.Series(1).Clear();
                    axTChart1.Series(2).Clear();
                    axTChart1.Series(3).Clear();
                    axTChart1.Series(4).Clear();
                    axTChart1.Series(5).Clear();
                    //axTChart1.Series(0).AddArray(5000, Warning.ToArray());
                    drawWarningLine();
                    clearOrder();
                    还原ToolStripMenuItem_Click(null, null);
                }
            }));
        }

        private void 还原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axTChart1.Invoke((EventHandler)(delegate
            {
                if (receiveData.Count <= 200)
                {
                    axTChart1.Axis.Bottom.Minimum = 0;
                    axTChart1.Axis.Bottom.Maximum = 200;
                }
                else
                {
                    //注意：X轴min不能大于max
                    if(receiveData.Count + 10 <= axTChart1.Axis.Bottom.Minimum)
                    {                      
                        axTChart1.Axis.Bottom.Minimum = receiveData.Count + 10 - 200;
                        axTChart1.Axis.Bottom.Maximum = receiveData.Count + 10;
                    }
                    else
                    {
                        axTChart1.Axis.Bottom.Maximum = receiveData.Count + 10;
                        axTChart1.Axis.Bottom.Minimum = axTChart1.Axis.Bottom.Maximum - 200;
                    }        
                }
                axTChart1.Axis.Left.Minimum = 0;
                axTChart1.Axis.Left.Maximum = 80;
            }));
        }

        private void axTChart1_OnDblClick(object sender, EventArgs e)
        {
            axTChart1.Invoke((EventHandler)(delegate
            {
                axTChart1.Axis.Bottom.Minimum = 0;
                axTChart1.Axis.Bottom.Maximum = 200;
                axTChart1.Axis.Left.Maximum = 80;
                axTChart1.Axis.Left.Minimum = 0;
            }));
        }

        private void axTChart1_OnMouseUp(object sender, ITChartEvents_OnMouseUpEvent e)
        {
            if (e.button == TeeChart.EMouseButton.mbRight)
                contextMenuStrip1.Show(axTChart1, e.x, e.y);
        }

        private void sendStop()
        {
            byte[] a = { 0x24, 0x24, 0x55, 0x0D, 0x0A };
            serialPort1.Write(a, 0, a.Length);
        }

        private int WorkStatus//通过属性赋值，触发不同的事件
        {
            get { return workStatus; }
            set
            {
                //如果赋的值与原值不同
                if (value != workStatus)
                {
                    workStatus = value;
                    //就触发该事件!
                    StatusChange();
                }
                //然后赋值!
                workStatus = value;
            }
        }

        /// <summary>
        /// 工作状态切换
        /// </summary>
        private void StatusChange()
        {
            if(WorkStatus==0)//停止
            {
                Enable(btnStart);
                disEnable(btnStop);
                disEnable(btnPrint);
                Enable(btnFind);
                Enable(btnCheck);
                textBox1.ReadOnly = false;
                Enable(btnOut);
                Enable(btnSave);
                disEnable(btnAdd);
            }
            else if(WorkStatus==1)//工作中
            {
                Enable(btnStart);
                Enable(btnStop);
                disEnable(btnPrint);
                disEnable(btnFind);
                disEnable(btnCheck);
                textBox1_TextChanged(null, null);
                textBox1.ReadOnly = true;
                disEnable(btnOut);
            }
            else if(WorkStatus==2)//硬件检测
            {
                disEnable(btnStart);
                disEnable(btnStop);
                disEnable(btnPrint);
                disEnable(btnFind);
                Enable(btnCheck);
                textBox1.ReadOnly = false;
                disEnable(btnOut);
            }
            else if(WorkStatus==3)//暂停
            {
                Enable(btnStart);
                Enable(btnStop);
                disEnable(btnPrint);
                disEnable(btnFind);
                disEnable(btnCheck);
                textBox1.ReadOnly = true;
                textBox1.ForeColor = Color.Red;
                Enable(btnOut);
            }
        }

        private void disEnable(Button button)
        {
            button.Invoke((EventHandler)(delegate
            {
                button.Enabled = false;
                button.BackColor = Color.Gainsboro;
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.ResetText();
        }

        private void resetWarning()
        {
            Warning.Clear();
            for (int i = 0; i < 1000; i++)
                Warning.Add(JingShi);
        }

        /// <summary>
        /// 画警示线
        /// </summary>
        private void drawWarningLine()
        {
            axTChart1.Invoke((EventHandler)(delegate
            {
                for(int i = 0; i < Warning.Count; i++)
                {
                    axTChart1.Series(0).AddXY(i, Warning[i],"", 255);
                    axTChart1.Series(4).AddXY(i, Warning[i] - 5, "", 255);
                    axTChart1.Series(5).AddXY(i, Warning[i] + 5, "", 255);
                }
            }));
        }

        private void drawOrder(Dictionary<int,Point> order)
        {
            axTChart1.Series(2).Clear();
            if (order.Count > 0)
            {
                foreach (KeyValuePair<int, Point> i in order)
                {
                    axTChart1.Series(2).AddXY(i.Value.X, i.Value.Y, "标本" + i.Key.ToString(), 255);
                }
            }
        }   

        private void clearOrder()
        {
            order.Clear();
            toolStripComboBox2.Items.Clear();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void panel_top_Click(object sender, EventArgs e)
        {
            panel_top.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                              this.panel1.ClientRectangle,
                              Color.FromArgb(220, 220, 220),//7f9db9
                              2,
                              ButtonBorderStyle.None,
                              Color.FromArgb(220, 220, 220),
                              1,
                              ButtonBorderStyle.Solid,
                              Color.FromArgb(173, 220, 250),
                              1,
                              ButtonBorderStyle.Solid,
                              Color.FromArgb(173, 220, 250),
                              1,
                              ButtonBorderStyle.Solid);
        }

        /// <summary>
        /// 曲线标号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int key = toolStripComboBox1.SelectedIndex + 1;
            if (!order.ContainsKey(key))
            { 
                if (contextMenuPoint.X != 0)
                {
                    Point p = new Point();
                    p.X = (int)((axTChart1.Axis.Bottom.Maximum - axTChart1.Axis.Bottom.Minimum) * contextMenuPoint.X) / axisWidth + (int)axTChart1.Axis.Bottom.Minimum;
                    p.Y = (80 * contextMenuPoint.Y) / axisHeight;
                    order.Add(key, p);
                    toolStripComboBox2.Items.Add(key);
                    drawOrder(order);
                }
            }
            else
            {
                MessageBox.Show("该标号已存在！","警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 自动标号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 自动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(order.Count == 0)
            {
                int key = 1;
                if (contextMenuPoint.X != 0)
                {
                    Point p = new Point();
                    p.X = (int)((axTChart1.Axis.Bottom.Maximum - axTChart1.Axis.Bottom.Minimum) * contextMenuPoint.X) / axisWidth + (int)axTChart1.Axis.Bottom.Minimum;
                    p.Y = (80 * contextMenuPoint.Y) / axisHeight;
                    order.Add(key, p);
                    toolStripComboBox2.Items.Add(key);
                    drawOrder(order);               
                }
            }
            else
            {
                int key = order.Keys.Max() + 1;
                if (contextMenuPoint.X != 0)
                {
                    Point p = new Point();
                    p.X = (int)(200 * contextMenuPoint.X) / axisWidth + (int)(axTChart1.Axis.Bottom.Maximum - 200);
                    p.Y = (80 * contextMenuPoint.Y) / axisHeight;
                    order.Add(key, p);
                    toolStripComboBox2.Items.Add(key);
                    drawOrder(order);
                }
            }
        }

        /// <summary>
        /// 取消标号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int key = (int)toolStripComboBox2.SelectedItem;
            order.Remove(key);
            drawOrder(order);
            toolStripComboBox2.Items.Remove(toolStripComboBox2.SelectedItem);
        }

        /// <summary>
        /// 快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.S) && e.Shift && btnStart.Text == "开  始(S)")
            {
                e.Handled = true;
                btnStart_Click(null, null);
            }
            if (e.KeyCode == (Keys.P) && e.Shift && btnStart.Text == "暂  停(P)")
            {
                e.Handled = true;
                btnStart.Text = "开  始(S)";
                WorkStatus = 3;
                btnStart.Text = "继  续(C)";
            }
            if (e.KeyCode == (Keys.C) && e.Shift && btnStart.Text == "继  续(C)")
            {
                e.Handled = true;
                btnStart.Text = "暂  停(P)";
                WorkStatus = 1;
            }
            if (e.KeyCode == (Keys.E) && e.Shift && btnStop.Enabled == true)
            {
                e.Handled = true;
                btnStop_Click(null, null);
            }
        }

        /// <summary>
        /// 曲线标号坐标
        /// </summary>
        private Point contextMenuPoint;//标号像素点坐标
        private int axisWidth = 1130;//X轴像素宽度
        private int axisHeight = 247;//Y轴像素高度

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            Point p = axTChart1.PointToClient(Control.MousePosition);
            if(p.X > 75 + 40 && p.X < 1205 && p.Y >54 && p.Y < 301)
            {
                contextMenuPoint = new Point(p.X - 75, axTChart1.Height - p.Y - 51);
                axisWidth = axTChart1.Width - 75 - 37;//控件中左右的留白长度
                axisHeight = axTChart1.Height - 54 - 51;//控件中上下的留白长度
            }
            else
            {
                contextMenuPoint = new Point(0, 0);
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 1 && e.KeyChar != 3 && e.KeyChar != 22 && e.KeyChar != 46)
            {
                MessageBox.Show("请输入数字!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearAllInput();
            clearOrder();
            Enable(btnSave);
            disEnable(btnAdd);
        }

        private void Enable(Button button)
        {
            button.Invoke((EventHandler)(delegate
            {
                button.Enabled = true;
                button.BackColor= Color.FromArgb(192, 255, 255);
            }));
        }

    }
}
