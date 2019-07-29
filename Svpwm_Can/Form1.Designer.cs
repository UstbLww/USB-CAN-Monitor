namespace Svpwm_Can
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_set = new System.Windows.Forms.GroupBox();
            this.button_Scan = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.comboBox_Bps = new System.Windows.Forms.ComboBox();
            this.comboBox_Ports = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label_Buffersize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_ErrNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Vel = new System.Windows.Forms.Label();
            this.label_Udc = new System.Windows.Forms.Label();
            this.label_Ic = new System.Windows.Forms.Label();
            this.label_Ia = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_Ia = new System.Windows.Forms.Button();
            this.button_Ic = new System.Windows.Forms.Button();
            this.button_Udc = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_Vector = new System.Windows.Forms.Button();
            this.tabControl1 = new Svpwm_Can.FullTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Test = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Record = new System.Windows.Forms.Button();
            this.button_ControlSend = new System.Windows.Forms.Button();
            this.textBox_CanID = new System.Windows.Forms.TextBox();
            this.numericUpDown_Vel = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_set.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Vel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_set
            // 
            this.groupBox_set.Controls.Add(this.button_Scan);
            this.groupBox_set.Controls.Add(this.button_Close);
            this.groupBox_set.Controls.Add(this.button_Open);
            this.groupBox_set.Controls.Add(this.comboBox_Bps);
            this.groupBox_set.Controls.Add(this.comboBox_Ports);
            this.groupBox_set.Controls.Add(this.label2);
            this.groupBox_set.Controls.Add(this.label1);
            this.groupBox_set.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_set.Location = new System.Drawing.Point(12, 12);
            this.groupBox_set.Name = "groupBox_set";
            this.groupBox_set.Size = new System.Drawing.Size(299, 207);
            this.groupBox_set.TabIndex = 0;
            this.groupBox_set.TabStop = false;
            this.groupBox_set.Text = "设置";
            // 
            // button_Scan
            // 
            this.button_Scan.Location = new System.Drawing.Point(169, 44);
            this.button_Scan.Name = "button_Scan";
            this.button_Scan.Size = new System.Drawing.Size(75, 25);
            this.button_Scan.TabIndex = 3;
            this.button_Scan.Text = "扫描";
            this.button_Scan.UseVisualStyleBackColor = true;
            this.button_Scan.Click += new System.EventHandler(this.button_Scan_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(166, 165);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(80, 28);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "关闭端口";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(24, 165);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(80, 28);
            this.button_Open.TabIndex = 2;
            this.button_Open.Text = "打开端口";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // comboBox_Bps
            // 
            this.comboBox_Bps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Bps.FormattingEnabled = true;
            this.comboBox_Bps.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_Bps.Location = new System.Drawing.Point(64, 104);
            this.comboBox_Bps.Name = "comboBox_Bps";
            this.comboBox_Bps.Size = new System.Drawing.Size(83, 22);
            this.comboBox_Bps.TabIndex = 1;
            // 
            // comboBox_Ports
            // 
            this.comboBox_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ports.FormattingEnabled = true;
            this.comboBox_Ports.Items.AddRange(new object[] {
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comboBox_Ports.Location = new System.Drawing.Point(64, 46);
            this.comboBox_Ports.Name = "comboBox_Ports";
            this.comboBox_Ports.Size = new System.Drawing.Size(83, 22);
            this.comboBox_Ports.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口：";
            // 
            // serialPort1
            // 
            this.serialPort1.ReceivedBytesThreshold = 30;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "缓冲字节：";
            // 
            // label_Buffersize
            // 
            this.label_Buffersize.AutoSize = true;
            this.label_Buffersize.Location = new System.Drawing.Point(548, 383);
            this.label_Buffersize.Name = "label_Buffersize";
            this.label_Buffersize.Size = new System.Drawing.Size(13, 13);
            this.label_Buffersize.TabIndex = 3;
            this.label_Buffersize.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "错误帧数：";
            // 
            // label_ErrNum
            // 
            this.label_ErrNum.AutoSize = true;
            this.label_ErrNum.Location = new System.Drawing.Point(548, 409);
            this.label_ErrNum.Name = "label_ErrNum";
            this.label_ErrNum.Size = new System.Drawing.Size(13, 13);
            this.label_ErrNum.TabIndex = 3;
            this.label_ErrNum.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(10, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current a(A):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(10, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Current c(A):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(10, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "母线电压U(V):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(10, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "转速Vel(rpm):";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label_Vel);
            this.groupBox1.Controls.Add(this.label_Udc);
            this.groupBox1.Controls.Add(this.label_Ic);
            this.groupBox1.Controls.Add(this.label_Ia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(339, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 231);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "回显";
            // 
            // label_Vel
            // 
            this.label_Vel.AutoSize = true;
            this.label_Vel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Vel.Location = new System.Drawing.Point(126, 161);
            this.label_Vel.MaximumSize = new System.Drawing.Size(100, 0);
            this.label_Vel.MinimumSize = new System.Drawing.Size(60, 0);
            this.label_Vel.Name = "label_Vel";
            this.label_Vel.Size = new System.Drawing.Size(60, 16);
            this.label_Vel.TabIndex = 5;
            this.label_Vel.Text = "0";
            // 
            // label_Udc
            // 
            this.label_Udc.AutoSize = true;
            this.label_Udc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Udc.Location = new System.Drawing.Point(126, 119);
            this.label_Udc.MaximumSize = new System.Drawing.Size(100, 0);
            this.label_Udc.MinimumSize = new System.Drawing.Size(60, 0);
            this.label_Udc.Name = "label_Udc";
            this.label_Udc.Size = new System.Drawing.Size(60, 16);
            this.label_Udc.TabIndex = 5;
            this.label_Udc.Text = "0";
            // 
            // label_Ic
            // 
            this.label_Ic.AutoSize = true;
            this.label_Ic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Ic.Location = new System.Drawing.Point(126, 77);
            this.label_Ic.MaximumSize = new System.Drawing.Size(100, 0);
            this.label_Ic.MinimumSize = new System.Drawing.Size(60, 0);
            this.label_Ic.Name = "label_Ic";
            this.label_Ic.Size = new System.Drawing.Size(60, 16);
            this.label_Ic.TabIndex = 5;
            this.label_Ic.Text = "0";
            // 
            // label_Ia
            // 
            this.label_Ia.AutoSize = true;
            this.label_Ia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Ia.Location = new System.Drawing.Point(126, 35);
            this.label_Ia.MaximumSize = new System.Drawing.Size(100, 0);
            this.label_Ia.MinimumSize = new System.Drawing.Size(60, 0);
            this.label_Ia.Name = "label_Ia";
            this.label_Ia.Size = new System.Drawing.Size(60, 16);
            this.label_Ia.TabIndex = 5;
            this.label_Ia.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(10, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 14);
            this.label12.TabIndex = 4;
            this.label12.Text = "电压矢量是否超范围:";
            // 
            // button_Ia
            // 
            this.button_Ia.BackColor = System.Drawing.SystemColors.Control;
            this.button_Ia.BackgroundImage = global::Svpwm_Can.Properties.Resources.Green_light;
            this.button_Ia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Ia.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Ia.FlatAppearance.BorderSize = 0;
            this.button_Ia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ia.Location = new System.Drawing.Point(550, 39);
            this.button_Ia.Name = "button_Ia";
            this.button_Ia.Size = new System.Drawing.Size(32, 32);
            this.button_Ia.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_Ia, "绿：正常\r\n红：超出范围");
            this.button_Ia.UseVisualStyleBackColor = false;
            // 
            // button_Ic
            // 
            this.button_Ic.BackColor = System.Drawing.SystemColors.Control;
            this.button_Ic.BackgroundImage = global::Svpwm_Can.Properties.Resources.Green_light;
            this.button_Ic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Ic.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Ic.FlatAppearance.BorderSize = 0;
            this.button_Ic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ic.Location = new System.Drawing.Point(550, 81);
            this.button_Ic.Name = "button_Ic";
            this.button_Ic.Size = new System.Drawing.Size(32, 32);
            this.button_Ic.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_Ic, "绿：正常\r\n红：超出范围");
            this.button_Ic.UseVisualStyleBackColor = false;
            // 
            // button_Udc
            // 
            this.button_Udc.BackColor = System.Drawing.SystemColors.Control;
            this.button_Udc.BackgroundImage = global::Svpwm_Can.Properties.Resources.Green_light;
            this.button_Udc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Udc.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Udc.FlatAppearance.BorderSize = 0;
            this.button_Udc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Udc.Location = new System.Drawing.Point(550, 123);
            this.button_Udc.Name = "button_Udc";
            this.button_Udc.Size = new System.Drawing.Size(32, 32);
            this.button_Udc.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_Udc, "绿：正常\r\n黄：母线欠压\r\n红：超出范围");
            this.button_Udc.UseVisualStyleBackColor = false;
            // 
            // button_Vector
            // 
            this.button_Vector.BackColor = System.Drawing.SystemColors.Control;
            this.button_Vector.BackgroundImage = global::Svpwm_Can.Properties.Resources.Green_light;
            this.button_Vector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Vector.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Vector.FlatAppearance.BorderSize = 0;
            this.button_Vector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Vector.Location = new System.Drawing.Point(550, 206);
            this.button_Vector.Name = "button_Vector";
            this.button_Vector.Size = new System.Drawing.Size(32, 32);
            this.button_Vector.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_Vector, "绿：正常\r\n红：超出范围");
            this.button_Vector.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 10F);
            this.tabControl1.Location = new System.Drawing.Point(12, 250);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(303, 198);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.button_Clear);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox_Test);
            this.tabPage1.Location = new System.Drawing.Point(2, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(297, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CanTest";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(184, 147);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(60, 23);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "清空";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "测试接收数据：";
            // 
            // textBox_Test
            // 
            this.textBox_Test.Location = new System.Drawing.Point(5, 38);
            this.textBox_Test.Multiline = true;
            this.textBox_Test.Name = "textBox_Test";
            this.textBox_Test.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Test.Size = new System.Drawing.Size(236, 103);
            this.textBox_Test.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.button_Record);
            this.tabPage2.Controls.Add(this.button_ControlSend);
            this.tabPage2.Controls.Add(this.textBox_CanID);
            this.tabPage2.Controls.Add(this.numericUpDown_Vel);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(2, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(297, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Control";
            // 
            // button_Record
            // 
            this.button_Record.Location = new System.Drawing.Point(151, 98);
            this.button_Record.Name = "button_Record";
            this.button_Record.Size = new System.Drawing.Size(75, 23);
            this.button_Record.TabIndex = 3;
            this.button_Record.Text = "记录数据";
            this.button_Record.UseVisualStyleBackColor = true;
            this.button_Record.Click += new System.EventHandler(this.button_Record_Click);
            // 
            // button_ControlSend
            // 
            this.button_ControlSend.Location = new System.Drawing.Point(12, 98);
            this.button_ControlSend.Name = "button_ControlSend";
            this.button_ControlSend.Size = new System.Drawing.Size(75, 23);
            this.button_ControlSend.TabIndex = 3;
            this.button_ControlSend.Text = "发送";
            this.button_ControlSend.UseVisualStyleBackColor = true;
            this.button_ControlSend.Click += new System.EventHandler(this.button_ControlSend_Click);
            // 
            // textBox_CanID
            // 
            this.textBox_CanID.Enabled = false;
            this.textBox_CanID.Location = new System.Drawing.Point(126, 13);
            this.textBox_CanID.Name = "textBox_CanID";
            this.textBox_CanID.Size = new System.Drawing.Size(100, 23);
            this.textBox_CanID.TabIndex = 2;
            this.textBox_CanID.Text = "0055";
            // 
            // numericUpDown_Vel
            // 
            this.numericUpDown_Vel.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Vel.Location = new System.Drawing.Point(125, 56);
            this.numericUpDown_Vel.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numericUpDown_Vel.Name = "numericUpDown_Vel";
            this.numericUpDown_Vel.Size = new System.Drawing.Size(102, 23);
            this.numericUpDown_Vel.TabIndex = 1;
            this.numericUpDown_Vel.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10F);
            this.label11.Location = new System.Drawing.Point(8, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "CAN ID(标准帧)：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10F);
            this.label10.Location = new System.Drawing.Point(9, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "速度Vel(rpm)：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 451);
            this.Controls.Add(this.button_Vector);
            this.Controls.Add(this.button_Udc);
            this.Controls.Add(this.button_Ic);
            this.Controls.Add(this.button_Ia);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_ErrNum);
            this.Controls.Add(this.label_Buffersize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox_set);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Svpwm_Can";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_set.ResumeLayout(false);
            this.groupBox_set.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Vel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_set;
        private System.Windows.Forms.Button button_Scan;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.ComboBox comboBox_Bps;
        private System.Windows.Forms.ComboBox comboBox_Ports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Buffersize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_ErrNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Vel;
        private System.Windows.Forms.Label label_Udc;
        private System.Windows.Forms.Label label_Ic;
        private System.Windows.Forms.Label label_Ia;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Test;
        private System.Windows.Forms.Label label10;
        private FullTabControl tabControl1;
        private System.Windows.Forms.TextBox textBox_CanID;
        private System.Windows.Forms.NumericUpDown numericUpDown_Vel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_ControlSend;
        private System.Windows.Forms.Button button_Record;
        private System.Windows.Forms.Button button_Ia;
        private System.Windows.Forms.Button button_Ic;
        private System.Windows.Forms.Button button_Udc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_Vector;
        private System.Windows.Forms.Button button_Clear;
    }
}

