using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using NaDetector.classUnity;
using System.IO;

namespace PetDetector
{
    public partial class AllPatients : Form
    {
        double JingShi = 0;//警示值
        double[] receiveData = null;//数据
        int[] sequence = null;//标号
        Point[] coordinate = null;//标号坐标
        Dictionary<string, DataRow> rows = new Dictionary<string, DataRow>();

        public AllPatients()
        {
            InitializeComponent();
        }

        private void AllPets_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now.AddDays(-7);
            dateTimePicker2.Value = dateTime;

            //图标显示控件设定
            axTChart1.Legend.DividingLines.Visible = true;
            axTChart1.Environment.MouseWheelScroll = false;//取消鼠标滚轮滑动
            axTChart1.Scroll.Enable = TeeChart.EChartScroll.pmHorizontal;//水平滚动
            axTChart1.Scroll.MouseButton = TeeChart.EMouseButton.mbRight;//右键滚动
            axTChart1.Zoom.Enable = true;//开启缩放

            try
            {
                //初始化显示一周内的病人记录
                QueryParameter queryParameter = getQueryParameter();
                DataTable table = SqlDeal.getPatientsByParameters(queryParameter);

                foreach (DataRow row in table.Rows)
                {
                    rows.Add(row["hospitalnumber"].ToString(), row);
                }

                DataTable dat = table.DefaultView.ToTable(false, new string[] { "hospitalnumber","name", "sex", "category","ifchecked" });
                renameTable(dat);
                dataGridView1.DataSource = dat;
            }
            catch (Exception e1)
            {
               
            }
        }

        /// <summary>
        /// 数据库查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCertain_Click(object sender, EventArgs e)
        {
            QueryParameter queryParameter = getQueryParameter();

            if (chcTimeSelect.Checked && dateTimePicker2.Value > dateTimePicker3.Value)
            {
                MessageBox.Show("起始日期需在结束日期之前", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;         
            }

            //查询数据库
            DataTable table1 = SqlDeal.getPatientsByParameters(queryParameter);
            rows.Clear();
            foreach (DataRow row in table1.Rows)
            {
                rows.Add(row["hospitalnumber"].ToString(), row);
            }
            DataTable dat1 = table1.DefaultView.ToTable(false, new string[] { "hospitalnumber", "name", "sex", "category", "ifchecked" });
            renameTable(dat1);
            dataGridView1.DataSource = dat1;
        }

        /// <summary>
        /// 病人检测信息展示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
                return;
            string hospitalNumber = dataGridView1.CurrentRow.Cells["住院号"].Value.ToString();
            if (rows.ContainsKey(hospitalNumber))
            {
                try
                {
                    DataRow row = rows[hospitalNumber];
                    dateTimePicker1.Value = Convert.ToDateTime(row["time"].ToString());
                    txtHospitalNumber.Text = row["hospitalnumber"].ToString();
                    txtName.Text = row["name"].ToString();
                    txtAge.Text = row["age"].ToString();
                    txtBedNumber.Text = (row["bednumber"].ToString());
                    cbCateGory.Text = row["category"].ToString();
                    cbSex.Text = row["sex"].ToString();
                    rtxtRemark.Text = row["remark"].ToString();
                    axTChart1.Series(0).Clear();
                    axTChart1.Series(1).Clear();
                    axTChart1.Series(2).Clear();
                    axTChart1.Series(3).Clear();
                    axTChart1.Series(4).Clear();

                    if ((bool)row["ifchecked"])
                    {
                        JingShi = (double)(row["jingshi"]);
                        receiveData = toolUnity.Tool.byteToDouble((byte[])(row["receivedata"]));
                        sequence = toolUnity.Tool.buyeToInt((byte[])(row["sequence"]));
                        coordinate = toolUnity.Tool.byteToPoint((byte[])(row["coordinate"]));
                        orderShow(sequence);

                        axTChart1.Axis.Bottom.Maximum = receiveData.Length + 10;
                        axTChart1.Axis.Bottom.Minimum = 0;
                        for (int i = 0; i < receiveData.Length; i++)
                        {
                            axTChart1.Series(0).AddXY(i, JingShi, i.ToString(), 65535);
                            axTChart1.Series(3).AddXY(i, JingShi - 5, i.ToString(), 65535);
                            axTChart1.Series(4).AddXY(i, JingShi + 5, i.ToString(), 65535);
                            if (receiveData[i] > JingShi)
                            {
                                axTChart1.Series(1).AddXY(i, receiveData[i], i.ToString(), 16711935);
                            }
                            else
                            {
                                axTChart1.Series(1).AddXY(i, receiveData[i], i.ToString(), 16711680);
                            }
                        }
                        //标号显示
                        for(int i=0;i<sequence.Length;i++)
                        {
                            axTChart1.Series(2).AddXY(coordinate[i].X, coordinate[i].Y, "标本"+sequence[i].ToString(), 255);
                        }                               
                    }
                }
                catch (Exception ex)
                {
                                      
                }
            }
        }

        /// <summary>
        /// 封装查询数据库参数对象
        /// </summary>
        /// <returns></returns>
        private QueryParameter getQueryParameter()
        {
            QueryParameter queryParameter = new QueryParameter();
            queryParameter.name = txtNameSelect.Text;
            queryParameter.hospitalNumber = txtHospitalNumberSelect.Text;
            queryParameter.byTime = chcTimeSelect.Checked;
            queryParameter.startTime = dateTimePicker2.Value;
            queryParameter.endTime = dateTimePicker3.Value;
            queryParameter.sorted = chcSortByTime.Checked;
            return queryParameter;
        }

        /// <summary>
        /// DataTable重命名
        /// </summary>
        /// <param name="dat"></param>
        private void renameTable(DataTable dat)
        {
            dat.Columns["hospitalnumber"].ColumnName = "住院号";
            dat.Columns["name"].ColumnName = "姓名";
            dat.Columns["ifchecked"].ColumnName = "是否检测";
            dat.Columns["sex"].ColumnName = "性别";
            dat.Columns["category"].ColumnName = "科别";
        }

        /// <summary>
        /// 曲线查询
        /// </summary>
        private void orderShow(int[] sequence)
        {
            toolStripComboBox1.Items.Clear();
            foreach (int i in sequence)
            {
                toolStripComboBox1.Items.Add(i);
            }
        }

        /// <summary>
        /// Delete删除记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                btnDelete_Click_1(null, null);
            }
        }

        /// <summary>
        /// Button删除记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                return;
            }

            if (dataGridView1.CurrentRow.Index >= 0)
            {
                if (MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string hospitalNumber = dataGridView1.CurrentRow.Cells["住院号"].Value.ToString();
                    SqlDeal.deleteItem(hospitalNumber);

                    try
                    {
                        rows.Clear();
                        QueryParameter queryParameter = getQueryParameter();
                        DataTable table = SqlDeal.getPatientsByParameters(queryParameter);
                        foreach (DataRow row in table.Rows)
                        {
                            rows.Add(row["hospitalnumber"].ToString(), row);
                        }

                        DataTable dat = table.DefaultView.ToTable(false, new string[] { "hospitalnumber", "name", "sex", "category", "ifchecked" });
                        renameTable(dat);
                        dataGridView1.DataSource = dat;
                    }
                    catch (Exception e1)
                    {
                        throw e1;
                    }
                }
            }
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                return;
            }
            if (dataGridView1.CurrentRow.Index >= 0)
            {
                string hospitalNumber = dataGridView1.CurrentRow.Cells["住院号"].Value.ToString();
                string path = Application.StartupPath + @"\picture\" + txtHospitalNumber.Text + " " + txtName.Text + ".jpg";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                axTChart1.Export.asJPEG.SaveToFile(path);

                if (rows.ContainsKey(hospitalNumber))
                {
                    toolUnity.Tool.printWord(rows[hospitalNumber]);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chcTimeSelect.Checked)
            {
                panel7.Enabled = true;
            }
            else
            {
                panel7.Enabled = false;
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 图表双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axTChart1_OnDblClick(object sender, EventArgs e)
        {
            axTChart1.Invoke((EventHandler)(delegate
            {
                axTChart1.Axis.Bottom.Minimum = 0;
                axTChart1.Axis.Bottom.Maximum = 200;
                axTChart1.Axis.Left.Minimum = 0;
                axTChart1.Axis.Left.Maximum = 80;
            }));
        }

        /// <summary>
        /// 曲线还原
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 还原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axTChart1.Series(1).Count <= 200)
            {
                axTChart1.Axis.Bottom.Minimum = 0;
                axTChart1.Axis.Bottom.Maximum = 200;
            }
            else
            {
                axTChart1.Axis.Bottom.Minimum = 0;
                axTChart1.Axis.Bottom.Maximum = axTChart1.Series(1).Count + 10;
            }
            axTChart1.Axis.Left.Minimum = 0;
            axTChart1.Axis.Left.Maximum = 80;
        }

        /// <summary>
        /// 右击菜单显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axTChart1_OnMouseUp(object sender, AxTeeChart.ITChartEvents_OnMouseUpEvent e)
        {
            if (e.button == TeeChart.EMouseButton.mbRight)
                contextMenuStrip1.Show(axTChart1, e.x, e.y);
        }

        /// <summary>
        /// 跳转到对应标号的曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int start = toolStripComboBox1.SelectedIndex;
            int end = toolStripComboBox1.SelectedIndex + 1;
            try
            {               
                axTChart1.Axis.Bottom.Minimum = coordinate[start].X - 10;
                axTChart1.Axis.Bottom.Maximum = end < coordinate.Length ? coordinate[end].X + 10 : receiveData.Count() + 10;
            }
            catch
            {
                axTChart1.Axis.Bottom.Maximum = end < coordinate.Length ? coordinate[end].X + 10 : receiveData.Count() + 10;
                axTChart1.Axis.Bottom.Minimum = coordinate[start].X - 10;
            }
        }

        private void btnOneWeek_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Now.AddDays(-7);
            dateTimePicker3.Value = DateTime.Now;
            btnCertain_Click(null, null);
        }

        private void btnOneMonth_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Now.AddMonths(-1);
            dateTimePicker3.Value = DateTime.Now;
            btnCertain_Click(null, null);
        }

        private void chcSortByTime_CheckedChanged(object sender, EventArgs e)
        {
            btnCertain_Click(null, null);
        }
    }
}
