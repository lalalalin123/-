namespace PetDetector
{
    partial class AllPatients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllPatients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chcSortByTime = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnOneMonth = new System.Windows.Forms.Button();
            this.btnOneWeek = new System.Windows.Forms.Button();
            this.lbStart = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.lbStop = new System.Windows.Forms.Label();
            this.chcTimeSelect = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHospitalNumberSelect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameSelect = new System.Windows.Forms.TextBox();
            this.btnCertain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.axTChart1 = new AxTeeChart.AxTChart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtRemark = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSex = new System.Windows.Forms.TextBox();
            this.cbCateGory = new System.Windows.Forms.TextBox();
            this.txtBedNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.laDay = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtHospitalNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.laEx = new System.Windows.Forms.Label();
            this.laRoom = new System.Windows.Forms.Label();
            this.laHos = new System.Windows.Forms.Label();
            this.laAge = new System.Windows.Forms.Label();
            this.laSex = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.还原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTChart1)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 770);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(0, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(420, 605);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chcSortByTime);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.chcTimeSelect);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtHospitalNumberSelect);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txtNameSelect);
            this.panel6.Controls.Add(this.btnCertain);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(420, 165);
            this.panel6.TabIndex = 0;
            // 
            // chcSortByTime
            // 
            this.chcSortByTime.AutoSize = true;
            this.chcSortByTime.Checked = true;
            this.chcSortByTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcSortByTime.Location = new System.Drawing.Point(327, 144);
            this.chcSortByTime.Name = "chcSortByTime";
            this.chcSortByTime.Size = new System.Drawing.Size(89, 19);
            this.chcSortByTime.TabIndex = 79;
            this.chcSortByTime.Text = "时间排序";
            this.chcSortByTime.UseVisualStyleBackColor = true;
            this.chcSortByTime.CheckedChanged += new System.EventHandler(this.chcSortByTime_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("宋体", 8.5F);
            this.label3.Location = new System.Drawing.Point(11, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 69);
            this.label3.TabIndex = 60;
            this.label3.Text = "时间查询";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.Controls.Add(this.btnOneMonth);
            this.panel7.Controls.Add(this.btnOneWeek);
            this.panel7.Controls.Add(this.lbStart);
            this.panel7.Controls.Add(this.dateTimePicker2);
            this.panel7.Controls.Add(this.dateTimePicker3);
            this.panel7.Controls.Add(this.lbStop);
            this.panel7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel7.Location = new System.Drawing.Point(36, 9);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(380, 80);
            this.panel7.TabIndex = 75;
            // 
            // btnOneMonth
            // 
            this.btnOneMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOneMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOneMonth.FlatAppearance.BorderSize = 0;
            this.btnOneMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOneMonth.Font = new System.Drawing.Font("宋体", 11F);
            this.btnOneMonth.Location = new System.Drawing.Point(283, 43);
            this.btnOneMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnOneMonth.Name = "btnOneMonth";
            this.btnOneMonth.Size = new System.Drawing.Size(93, 29);
            this.btnOneMonth.TabIndex = 77;
            this.btnOneMonth.Text = "近一月";
            this.btnOneMonth.UseVisualStyleBackColor = false;
            this.btnOneMonth.Click += new System.EventHandler(this.btnOneMonth_Click);
            // 
            // btnOneWeek
            // 
            this.btnOneWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOneWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOneWeek.FlatAppearance.BorderSize = 0;
            this.btnOneWeek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOneWeek.Font = new System.Drawing.Font("宋体", 11F);
            this.btnOneWeek.Location = new System.Drawing.Point(283, 6);
            this.btnOneWeek.Margin = new System.Windows.Forms.Padding(4);
            this.btnOneWeek.Name = "btnOneWeek";
            this.btnOneWeek.Size = new System.Drawing.Size(93, 29);
            this.btnOneWeek.TabIndex = 76;
            this.btnOneWeek.Text = "近一周";
            this.btnOneWeek.UseVisualStyleBackColor = false;
            this.btnOneWeek.Click += new System.EventHandler(this.btnOneWeek_Click);
            // 
            // lbStart
            // 
            this.lbStart.BackColor = System.Drawing.Color.Transparent;
            this.lbStart.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lbStart.Location = new System.Drawing.Point(5, 9);
            this.lbStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(81, 21);
            this.lbStart.TabIndex = 66;
            this.lbStart.Text = "起始日期";
            this.lbStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dateTimePicker2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(87, 6);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(193, 29);
            this.dateTimePicker2.TabIndex = 65;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dateTimePicker3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(87, 43);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(193, 29);
            this.dateTimePicker3.TabIndex = 67;
            // 
            // lbStop
            // 
            this.lbStop.BackColor = System.Drawing.Color.Transparent;
            this.lbStop.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lbStop.Location = new System.Drawing.Point(5, 43);
            this.lbStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStop.Name = "lbStop";
            this.lbStop.Size = new System.Drawing.Size(78, 26);
            this.lbStop.TabIndex = 68;
            this.lbStop.Text = "终止日期";
            this.lbStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chcTimeSelect
            // 
            this.chcTimeSelect.Checked = true;
            this.chcTimeSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcTimeSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chcTimeSelect.Location = new System.Drawing.Point(16, 4);
            this.chcTimeSelect.Name = "chcTimeSelect";
            this.chcTimeSelect.Size = new System.Drawing.Size(19, 18);
            this.chcTimeSelect.TabIndex = 74;
            this.chcTimeSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chcTimeSelect.UseVisualStyleBackColor = true;
            this.chcTimeSelect.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 73;
            this.label2.Text = "姓 名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHospitalNumberSelect
            // 
            this.txtHospitalNumberSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHospitalNumberSelect.Location = new System.Drawing.Point(219, 93);
            this.txtHospitalNumberSelect.Multiline = true;
            this.txtHospitalNumberSelect.Name = "txtHospitalNumberSelect";
            this.txtHospitalNumberSelect.Size = new System.Drawing.Size(92, 29);
            this.txtHospitalNumberSelect.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(154, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 72;
            this.label1.Text = "住院号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameSelect
            // 
            this.txtNameSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNameSelect.Location = new System.Drawing.Point(63, 93);
            this.txtNameSelect.Multiline = true;
            this.txtNameSelect.Name = "txtNameSelect";
            this.txtNameSelect.Size = new System.Drawing.Size(83, 29);
            this.txtNameSelect.TabIndex = 71;
            // 
            // btnCertain
            // 
            this.btnCertain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCertain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCertain.FlatAppearance.BorderSize = 0;
            this.btnCertain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCertain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCertain.Location = new System.Drawing.Point(319, 93);
            this.btnCertain.Margin = new System.Windows.Forms.Padding(4);
            this.btnCertain.Name = "btnCertain";
            this.btnCertain.Size = new System.Drawing.Size(93, 30);
            this.btnCertain.TabIndex = 69;
            this.btnCertain.Text = "查 询";
            this.btnCertain.UseVisualStyleBackColor = false;
            this.btnCertain.Click += new System.EventHandler(this.btnCertain_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(420, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 770);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1062, 770);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.axTChart1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 299);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1062, 392);
            this.panel4.TabIndex = 1;
            // 
            // axTChart1
            // 
            this.axTChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTChart1.Enabled = true;
            this.axTChart1.Location = new System.Drawing.Point(0, 0);
            this.axTChart1.Margin = new System.Windows.Forms.Padding(4);
            this.axTChart1.Name = "axTChart1";
            this.axTChart1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTChart1.OcxState")));
            this.axTChart1.Size = new System.Drawing.Size(1062, 392);
            this.axTChart1.TabIndex = 58;
            this.axTChart1.OnDblClick += new System.EventHandler(this.axTChart1_OnDblClick);
            this.axTChart1.OnMouseUp += new AxTeeChart.ITChartEvents_OnMouseUpEventHandler(this.axTChart1_OnMouseUp);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1062, 299);
            this.panel5.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtxtRemark);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(517, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(541, 291);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "备注";
            // 
            // rtxtRemark
            // 
            this.rtxtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtRemark.Location = new System.Drawing.Point(4, 31);
            this.rtxtRemark.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtRemark.Name = "rtxtRemark";
            this.rtxtRemark.ReadOnly = true;
            this.rtxtRemark.Size = new System.Drawing.Size(529, 228);
            this.rtxtRemark.TabIndex = 0;
            this.rtxtRemark.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cbSex);
            this.groupBox3.Controls.Add(this.cbCateGory);
            this.groupBox3.Controls.Add(this.txtBedNumber);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.laDay);
            this.groupBox3.Controls.Add(this.txtAge);
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
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(517, 291);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基本信息";
            // 
            // cbSex
            // 
            this.cbSex.Location = new System.Drawing.Point(370, 164);
            this.cbSex.Margin = new System.Windows.Forms.Padding(4);
            this.cbSex.MaxLength = 10;
            this.cbSex.Name = "cbSex";
            this.cbSex.ReadOnly = true;
            this.cbSex.Size = new System.Drawing.Size(124, 34);
            this.cbSex.TabIndex = 22;
            // 
            // cbCateGory
            // 
            this.cbCateGory.Location = new System.Drawing.Point(124, 225);
            this.cbCateGory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCateGory.MaxLength = 10;
            this.cbCateGory.Name = "cbCateGory";
            this.cbCateGory.ReadOnly = true;
            this.cbCateGory.Size = new System.Drawing.Size(124, 34);
            this.cbCateGory.TabIndex = 24;
            // 
            // txtBedNumber
            // 
            this.txtBedNumber.Location = new System.Drawing.Point(370, 228);
            this.txtBedNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtBedNumber.MaxLength = 10;
            this.txtBedNumber.Name = "txtBedNumber";
            this.txtBedNumber.ReadOnly = true;
            this.txtBedNumber.Size = new System.Drawing.Size(124, 34);
            this.txtBedNumber.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(265, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 59;
            this.label5.Text = "*床      号";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 42);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(375, 31);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // laDay
            // 
            this.laDay.AutoSize = true;
            this.laDay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDay.Location = new System.Drawing.Point(24, 42);
            this.laDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laDay.Name = "laDay";
            this.laDay.Size = new System.Drawing.Size(92, 27);
            this.laDay.TabIndex = 12;
            this.laDay.Text = "检测日期";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(124, 164);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.MaxLength = 40;
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(124, 34);
            this.txtAge.TabIndex = 3;
            // 
            // txtHospitalNumber
            // 
            this.txtHospitalNumber.Location = new System.Drawing.Point(370, 99);
            this.txtHospitalNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtHospitalNumber.Name = "txtHospitalNumber";
            this.txtHospitalNumber.ReadOnly = true;
            this.txtHospitalNumber.Size = new System.Drawing.Size(124, 34);
            this.txtHospitalNumber.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 99);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(124, 34);
            this.txtName.TabIndex = 0;
            // 
            // laEx
            // 
            this.laEx.AutoSize = true;
            this.laEx.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laEx.Location = new System.Drawing.Point(261, 167);
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
            this.laRoom.Location = new System.Drawing.Point(281, 162);
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
            this.laHos.Location = new System.Drawing.Point(257, 102);
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
            this.laAge.Location = new System.Drawing.Point(24, 167);
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
            this.laSex.Location = new System.Drawing.Point(16, 228);
            this.laSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSex.Name = "laSex";
            this.laSex.Size = new System.Drawing.Size(103, 27);
            this.laSex.TabIndex = 1;
            this.laSex.Text = "*科       别";
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laName.Location = new System.Drawing.Point(15, 99);
            this.laName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(101, 27);
            this.laName.TabIndex = 0;
            this.laName.Text = "*病人姓名";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.btnExit);
            this.panel8.Controls.Add(this.btnPrint);
            this.panel8.Controls.Add(this.btnDelete);
            this.panel8.Location = new System.Drawing.Point(0, 699);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1062, 66);
            this.panel8.TabIndex = 58;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(897, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 41);
            this.btnExit.TabIndex = 75;
            this.btnExit.Text = "退 出";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.Location = new System.Drawing.Point(753, 13);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 41);
            this.btnPrint.TabIndex = 74;
            this.btnPrint.Text = "打 印";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(610, 13);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 41);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "删 除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.还原ToolStripMenuItem,
            this.查看ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // 还原ToolStripMenuItem
            // 
            this.还原ToolStripMenuItem.Name = "还原ToolStripMenuItem";
            this.还原ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.还原ToolStripMenuItem.Text = "还原";
            this.还原ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.查看ToolStripMenuItem.Text = "曲线查看";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoSize = false;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(45, 28);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // AllPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1482, 770);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检测信息查询";
            this.Load += new System.EventHandler(this.AllPets_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTChart1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtRemark;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label laDay;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtHospitalNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label laEx;
        private System.Windows.Forms.Label laRoom;
        private System.Windows.Forms.Label laHos;
        private System.Windows.Forms.Label laAge;
        private System.Windows.Forms.Label laSex;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label lbStop;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Button btnCertain;
        private System.Windows.Forms.DataGridView dataGridView1;
        public AxTeeChart.AxTChart axTChart1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox cbCateGory;
        private System.Windows.Forms.TextBox txtBedNumber;
        private System.Windows.Forms.TextBox cbSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHospitalNumberSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSelect;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox chcTimeSelect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 还原ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Button btnOneMonth;
        private System.Windows.Forms.Button btnOneWeek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chcSortByTime;
    }
}