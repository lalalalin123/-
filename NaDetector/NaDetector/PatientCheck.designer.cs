namespace PetDetector
{
    partial class PatientCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientCheck));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSaveElse = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.axTChart1 = new AxTeeChart.AxTChart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtRemark = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnQuary = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBedNumber = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.laDay = new System.Windows.Forms.Label();
            this.txtHospitalNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.laEx = new System.Windows.Forms.Label();
            this.laRoom = new System.Windows.Forms.Label();
            this.laHos = new System.Windows.Forms.Label();
            this.laAge = new System.Windows.Forms.Label();
            this.laSex = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.取消标号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTChart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.btnOut);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnSaveElse);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(1243, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 763);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnFind.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnFind.Location = new System.Drawing.Point(21, 444);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(147, 56);
            this.btnFind.TabIndex = 57;
            this.btnFind.Text = "查看/打印";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnCheck.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheck.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCheck.Location = new System.Drawing.Point(21, 508);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(147, 56);
            this.btnCheck.TabIndex = 56;
            this.btnCheck.Text = "硬件测试";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOut.FlatAppearance.BorderSize = 0;
            this.btnOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnOut.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOut.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnOut.Location = new System.Drawing.Point(21, 652);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(147, 56);
            this.btnOut.TabIndex = 55;
            this.btnOut.Text = "退出系统";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnPrint.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnPrint.Location = new System.Drawing.Point(21, 299);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(147, 56);
            this.btnPrint.TabIndex = 47;
            this.btnPrint.Text = "打   印";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSaveElse
            // 
            this.btnSaveElse.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveElse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveElse.Enabled = false;
            this.btnSaveElse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveElse.FlatAppearance.BorderSize = 0;
            this.btnSaveElse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnSaveElse.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveElse.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSaveElse.Location = new System.Drawing.Point(21, 235);
            this.btnSaveElse.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveElse.Name = "btnSaveElse";
            this.btnSaveElse.Size = new System.Drawing.Size(147, 56);
            this.btnSaveElse.TabIndex = 46;
            this.btnSaveElse.Text = "导出表格";
            this.btnSaveElse.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnStop.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnStop.Location = new System.Drawing.Point(21, 93);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(147, 56);
            this.btnStop.TabIndex = 41;
            this.btnStop.Text = "结  束(E)";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnStart.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnStart.Location = new System.Drawing.Point(21, 29);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 56);
            this.btnStart.TabIndex = 40;
            this.btnStart.Text = "开  始(S)";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 651);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.axTChart1);
            this.panel4.Location = new System.Drawing.Point(0, 299);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1243, 352);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1141, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.ReadOnly = true;
            this.label6.Size = new System.Drawing.Size(66, 30);
            this.label6.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1064, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "当前值";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(996, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 30);
            this.textBox1.TabIndex = 58;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(919, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "警示值";
            // 
            // axTChart1
            // 
            this.axTChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTChart1.Enabled = true;
            this.axTChart1.Location = new System.Drawing.Point(0, 0);
            this.axTChart1.Margin = new System.Windows.Forms.Padding(4);
            this.axTChart1.Name = "axTChart1";
            this.axTChart1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTChart1.OcxState")));
            this.axTChart1.Size = new System.Drawing.Size(1243, 352);
            this.axTChart1.TabIndex = 52;
            this.axTChart1.OnDblClick += new System.EventHandler(this.axTChart1_OnDblClick);
            this.axTChart1.OnMouseUp += new AxTeeChart.ITChartEvents_OnMouseUpEventHandler(this.axTChart1_OnMouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1243, 651);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtRemark);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(587, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(656, 295);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "备注";
            // 
            // rtxtRemark
            // 
            this.rtxtRemark.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxtRemark.Location = new System.Drawing.Point(8, 28);
            this.rtxtRemark.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtRemark.Name = "rtxtRemark";
            this.rtxtRemark.Size = new System.Drawing.Size(628, 236);
            this.rtxtRemark.TabIndex = 0;
            this.rtxtRemark.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtCategory);
            this.groupBox3.Controls.Add(this.txtAge);
            this.groupBox3.Controls.Add(this.btnQuary);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.txtBedNumber);
            this.groupBox3.Controls.Add(this.cbSex);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.laDay);
            this.groupBox3.Controls.Add(this.txtHospitalNumber);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.laEx);
            this.groupBox3.Controls.Add(this.laRoom);
            this.groupBox3.Controls.Add(this.laHos);
            this.groupBox3.Controls.Add(this.laAge);
            this.groupBox3.Controls.Add(this.laSex);
            this.groupBox3.Controls.Add(this.laName);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(4, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.groupBox3.Size = new System.Drawing.Size(587, 295);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基本信息";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(283, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 42);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.Text = "增    加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(145, 177);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategory.MaxLength = 10;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(132, 34);
            this.txtCategory.TabIndex = 67;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(145, 132);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.MaxLength = 10;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(132, 34);
            this.txtAge.TabIndex = 66;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // btnQuary
            // 
            this.btnQuary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuary.Location = new System.Drawing.Point(423, 222);
            this.btnQuary.Name = "btnQuary";
            this.btnQuary.Size = new System.Drawing.Size(112, 42);
            this.btnQuary.TabIndex = 65;
            this.btnQuary.Text = "查    询";
            this.btnQuary.UseVisualStyleBackColor = false;
            this.btnQuary.Click += new System.EventHandler(this.btnQuary_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(145, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 42);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "保    存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBedNumber
            // 
            this.txtBedNumber.Location = new System.Drawing.Point(403, 180);
            this.txtBedNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtBedNumber.Name = "txtBedNumber";
            this.txtBedNumber.Size = new System.Drawing.Size(132, 34);
            this.txtBedNumber.TabIndex = 63;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(403, 133);
            this.cbSex.Margin = new System.Windows.Forms.Padding(4);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(132, 35);
            this.cbSex.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(298, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 59;
            this.label5.Text = "*床      号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(40, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "带*号内容不能为空";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(403, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 32);
            this.button1.TabIndex = 57;
            this.button1.Text = "获取当前时间";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 42);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 31);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // laDay
            // 
            this.laDay.AutoSize = true;
            this.laDay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDay.Location = new System.Drawing.Point(43, 45);
            this.laDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laDay.Name = "laDay";
            this.laDay.Size = new System.Drawing.Size(92, 27);
            this.laDay.TabIndex = 12;
            this.laDay.Text = "检测日期";
            // 
            // txtHospitalNumber
            // 
            this.txtHospitalNumber.Location = new System.Drawing.Point(403, 89);
            this.txtHospitalNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtHospitalNumber.Name = "txtHospitalNumber";
            this.txtHospitalNumber.Size = new System.Drawing.Size(132, 34);
            this.txtHospitalNumber.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 89);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 34);
            this.txtName.TabIndex = 0;
            // 
            // laEx
            // 
            this.laEx.AutoSize = true;
            this.laEx.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laEx.Location = new System.Drawing.Point(294, 133);
            this.laEx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laEx.Name = "laEx";
            this.laEx.Size = new System.Drawing.Size(101, 27);
            this.laEx.TabIndex = 7;
            this.laEx.Text = "*病人性别";
            // 
            // laRoom
            // 
            this.laRoom.AutoSize = true;
            this.laRoom.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laRoom.ForeColor = System.Drawing.Color.Gray;
            this.laRoom.Location = new System.Drawing.Point(307, 132);
            this.laRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laRoom.Name = "laRoom";
            this.laRoom.Size = new System.Drawing.Size(64, 24);
            this.laRoom.TabIndex = 5;
            this.laRoom.Text = "病理号";
            this.laRoom.Visible = false;
            // 
            // laHos
            // 
            this.laHos.AutoSize = true;
            this.laHos.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHos.Location = new System.Drawing.Point(290, 89);
            this.laHos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laHos.Name = "laHos";
            this.laHos.Size = new System.Drawing.Size(105, 27);
            this.laHos.TabIndex = 3;
            this.laHos.Text = "*住  院  号";
            // 
            // laAge
            // 
            this.laAge.AutoSize = true;
            this.laAge.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laAge.Location = new System.Drawing.Point(44, 133);
            this.laAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laAge.Name = "laAge";
            this.laAge.Size = new System.Drawing.Size(92, 27);
            this.laAge.TabIndex = 2;
            this.laAge.Text = "病人年龄";
            // 
            // laSex
            // 
            this.laSex.AutoSize = true;
            this.laSex.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laSex.Location = new System.Drawing.Point(40, 180);
            this.laSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSex.Name = "laSex";
            this.laSex.Size = new System.Drawing.Size(97, 27);
            this.laSex.TabIndex = 1;
            this.laSex.Text = "*科      别";
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laName.Location = new System.Drawing.Point(36, 86);
            this.laName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(101, 27);
            this.laName.TabIndex = 0;
            this.laName.Text = "*病人姓名";
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1432, 62);
            this.panel_top.TabIndex = 2;
            this.panel_top.Click += new System.EventHandler(this.panel_top_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1424, 52);
            this.label1.TabIndex = 49;
            this.label1.Text = "肿瘤细胞检测软件(陕西中医药大学附属医院)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tag = "1";
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox2.ForeColor = System.Drawing.Color.Red;
            this.richTextBox2.Location = new System.Drawing.Point(0, 714);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(1243, 128);
            this.richTextBox2.TabIndex = 65;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem,
            this.还原ToolStripMenuItem,
            this.标号ToolStripMenuItem,
            this.取消标号ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 100);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // 还原ToolStripMenuItem
            // 
            this.还原ToolStripMenuItem.Name = "还原ToolStripMenuItem";
            this.还原ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.还原ToolStripMenuItem.Text = "还原";
            this.还原ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // 标号ToolStripMenuItem
            // 
            this.标号ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动ToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripComboBox1});
            this.标号ToolStripMenuItem.Name = "标号ToolStripMenuItem";
            this.标号ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.标号ToolStripMenuItem.Text = "标号";
            // 
            // 自动ToolStripMenuItem
            // 
            this.自动ToolStripMenuItem.Name = "自动ToolStripMenuItem";
            this.自动ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.自动ToolStripMenuItem.Text = "自动";
            this.自动ToolStripMenuItem.Click += new System.EventHandler(this.自动ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoSize = false;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(45, 28);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // 取消标号ToolStripMenuItem
            // 
            this.取消标号ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.取消标号ToolStripMenuItem.Name = "取消标号ToolStripMenuItem";
            this.取消标号ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.取消标号ToolStripMenuItem.Text = "取消标号";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.AutoSize = false;
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(45, 28);
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            // 
            // PatientCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1432, 842);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PatientCheck";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PetCheck_FormClosing);
            this.Load += new System.EventHandler(this.PetCheck_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PatientCheck_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTChart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label laDay;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtHospitalNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label laEx;
        private System.Windows.Forms.Label laRoom;
        private System.Windows.Forms.Label laHos;
        private System.Windows.Forms.Label laAge;
        private System.Windows.Forms.Label laSex;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtRemark;
        public AxTeeChart.AxTChart axTChart1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSaveElse;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标号ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBedNumber;
        private System.Windows.Forms.Button btnQuary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem 取消标号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem 自动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAdd;
    }
}