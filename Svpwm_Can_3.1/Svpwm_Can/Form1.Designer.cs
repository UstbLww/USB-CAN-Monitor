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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.button_Vector = new System.Windows.Forms.Button();
            this.label_Udc = new System.Windows.Forms.Label();
            this.button_Udc = new System.Windows.Forms.Button();
            this.label_Ic = new System.Windows.Forms.Label();
            this.button_Ic = new System.Windows.Forms.Button();
            this.label_Ia = new System.Windows.Forms.Label();
            this.button_Ia = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_Clear = new System.Windows.Forms.Button();
            this.textBox_Test = new System.Windows.Forms.TextBox();
            this.button_ControlSend = new System.Windows.Forms.Button();
            this.textBox_CanID = new System.Windows.Forms.TextBox();
            this.numericUpDown_Vel = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_Draw = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Rec = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_NoRec = new System.Windows.Forms.RadioButton();
            this.radioButton_Rec = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.button_ControlSend2 = new System.Windows.Forms.Button();
            this.numericUpDown_Vel2 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox_set.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Vel)).BeginInit();
            this.groupBox_Draw.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Vel2)).BeginInit();
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
            this.groupBox_set.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_set.Location = new System.Drawing.Point(16, 23);
            this.groupBox_set.Name = "groupBox_set";
            this.groupBox_set.Size = new System.Drawing.Size(299, 230);
            this.groupBox_set.TabIndex = 0;
            this.groupBox_set.TabStop = false;
            this.groupBox_set.Text = "设置";
            // 
            // button_Scan
            // 
            this.button_Scan.Location = new System.Drawing.Point(169, 44);
            this.button_Scan.Name = "button_Scan";
            this.button_Scan.Size = new System.Drawing.Size(75, 30);
            this.button_Scan.TabIndex = 3;
            this.button_Scan.Text = "扫描";
            this.button_Scan.UseVisualStyleBackColor = true;
            this.button_Scan.Click += new System.EventHandler(this.button_Scan_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(166, 165);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(80, 30);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "关闭端口";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(24, 165);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(80, 30);
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
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_Bps.Location = new System.Drawing.Point(64, 104);
            this.comboBox_Bps.Name = "comboBox_Bps";
            this.comboBox_Bps.Size = new System.Drawing.Size(83, 28);
            this.comboBox_Bps.TabIndex = 1;
            this.comboBox_Bps.SelectedIndexChanged += new System.EventHandler(this.comboBox_Bps_SelectedIndexChanged);
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
            this.comboBox_Ports.Size = new System.Drawing.Size(83, 28);
            this.comboBox_Ports.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
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
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label3.Location = new System.Drawing.Point(444, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "缓冲字节：";
            // 
            // label_Buffersize
            // 
            this.label_Buffersize.AutoSize = true;
            this.label_Buffersize.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label_Buffersize.Location = new System.Drawing.Point(529, 39);
            this.label_Buffersize.Name = "label_Buffersize";
            this.label_Buffersize.Size = new System.Drawing.Size(17, 20);
            this.label_Buffersize.TabIndex = 3;
            this.label_Buffersize.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label4.Location = new System.Drawing.Point(444, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "错误帧数：";
            // 
            // label_ErrNum
            // 
            this.label_ErrNum.AutoSize = true;
            this.label_ErrNum.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label_ErrNum.Location = new System.Drawing.Point(529, 73);
            this.label_ErrNum.Name = "label_ErrNum";
            this.label_ErrNum.Size = new System.Drawing.Size(17, 20);
            this.label_ErrNum.TabIndex = 3;
            this.label_ErrNum.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(10, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current a(A):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(10, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Current c(A):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(10, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "母线电压 U(V):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(10, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "转速 Vel(rpm):";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label_Vel);
            this.groupBox1.Controls.Add(this.button_Vector);
            this.groupBox1.Controls.Add(this.label_Udc);
            this.groupBox1.Controls.Add(this.button_Udc);
            this.groupBox1.Controls.Add(this.label_Ic);
            this.groupBox1.Controls.Add(this.button_Ic);
            this.groupBox1.Controls.Add(this.label_Ia);
            this.groupBox1.Controls.Add(this.button_Ia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(339, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 231);
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
            this.label_Vel.Size = new System.Drawing.Size(60, 22);
            this.label_Vel.TabIndex = 5;
            this.label_Vel.Text = "0";
            // 
            // button_Vector
            // 
            this.button_Vector.BackColor = System.Drawing.SystemColors.Control;
            this.button_Vector.BackgroundImage = global::Svpwm_Can.Properties.Resources.Green_light;
            this.button_Vector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Vector.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Vector.FlatAppearance.BorderSize = 0;
            this.button_Vector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Vector.Location = new System.Drawing.Point(216, 194);
            this.button_Vector.Name = "button_Vector";
            this.button_Vector.Size = new System.Drawing.Size(32, 32);
            this.button_Vector.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_Vector, "绿：正常\r\n红：超出范围");
            this.button_Vector.UseVisualStyleBackColor = false;
            // 
            // label_Udc
            // 
            this.label_Udc.AutoSize = true;
            this.label_Udc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Udc.Location = new System.Drawing.Point(126, 119);
            this.label_Udc.MaximumSize = new System.Drawing.Size(100, 0);
            this.label_Udc.MinimumSize = new System.Drawing.Size(60, 0);
            this.label_Udc.Name = "label_Udc";
            this.label_Udc.Size = new System.Drawing.Size(60, 22);
            this.label_Udc.TabIndex = 5;
            this.label_Udc.Text = "0";
            // 
            // button_Udc
            // 
            this.button_Udc.BackColor = System.Drawing.SystemColors.Control;
            this.button_Udc.BackgroundImage = global::Svpwm_Can.Properties.Resources.Green_light;
            this.button_Udc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Udc.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Udc.FlatAppearance.BorderSize = 0;
            this.button_Udc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Udc.Location = new System.Drawing.Point(216, 111);
            this.button_Udc.Name = "button_Udc";
            this.button_Udc.Size = new System.Drawing.Size(32, 32);
            this.button_Udc.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_Udc, "绿：正常\r\n黄：母线欠压\r\n红：超出范围");
            this.button_Udc.UseVisualStyleBackColor = false;
            // 
            // label_Ic
            // 
            this.label_Ic.AutoSize = true;
            this.label_Ic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Ic.Location = new System.Drawing.Point(126, 77);
            this.label_Ic.MaximumSize = new System.Drawing.Size(100, 0);
            this.label_Ic.MinimumSize = new System.Drawing.Size(60, 0);
            this.label_Ic.Name = "label_Ic";
            this.label_Ic.Size = new System.Drawing.Size(60, 22);
            this.label_Ic.TabIndex = 5;
            this.label_Ic.Text = "0";
            // 
            // button_Ic
            // 
            this.button_Ic.BackColor = System.Drawing.SystemColors.Control;
            this.button_Ic.BackgroundImage = global::Svpwm_Can.Properties.Resources.Green_light;
            this.button_Ic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Ic.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Ic.FlatAppearance.BorderSize = 0;
            this.button_Ic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ic.Location = new System.Drawing.Point(216, 69);
            this.button_Ic.Name = "button_Ic";
            this.button_Ic.Size = new System.Drawing.Size(32, 32);
            this.button_Ic.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_Ic, "绿：正常\r\n红：超出范围");
            this.button_Ic.UseVisualStyleBackColor = false;
            // 
            // label_Ia
            // 
            this.label_Ia.AutoSize = true;
            this.label_Ia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Ia.Location = new System.Drawing.Point(126, 35);
            this.label_Ia.MaximumSize = new System.Drawing.Size(100, 0);
            this.label_Ia.MinimumSize = new System.Drawing.Size(60, 0);
            this.label_Ia.Name = "label_Ia";
            this.label_Ia.Size = new System.Drawing.Size(60, 22);
            this.label_Ia.TabIndex = 5;
            this.label_Ia.Text = "0";
            // 
            // button_Ia
            // 
            this.button_Ia.BackColor = System.Drawing.SystemColors.Control;
            this.button_Ia.BackgroundImage = global::Svpwm_Can.Properties.Resources.Green_light;
            this.button_Ia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Ia.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Ia.FlatAppearance.BorderSize = 0;
            this.button_Ia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ia.Location = new System.Drawing.Point(216, 27);
            this.button_Ia.Name = "button_Ia";
            this.button_Ia.Size = new System.Drawing.Size(32, 32);
            this.button_Ia.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_Ia, "绿：正常\r\n红：超出范围");
            this.button_Ia.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(10, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "电压矢量是否超范围:";
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.ScaleView.SmallScrollMinSize = 5D;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 75.89761F;
            chartArea1.InnerPlotPosition.Width = 88F;
            chartArea1.InnerPlotPosition.X = 9F;
            chartArea1.InnerPlotPosition.Y = 6.14362F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 99F;
            chartArea1.Position.X = 1F;
            chartArea1.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.AutoFitMinFontSize = 6;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.MaximumAutoSize = 30F;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            legend1.TitleFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(9, 25);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "ia";
            series1.ToolTip = "\"#VALX,#VALY\"";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "ic";
            series2.ToolTip = "\"#VALX,#VALY\"";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(572, 162);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.BackColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 75.89761F;
            chartArea2.InnerPlotPosition.Width = 88F;
            chartArea2.InnerPlotPosition.X = 10F;
            chartArea2.InnerPlotPosition.Y = 6.14362F;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 94F;
            chartArea2.Position.Width = 99F;
            chartArea2.Position.Y = 3F;
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.AutoFitMinFontSize = 5;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.MaximumAutoSize = 30F;
            legend2.Name = "Legend1";
            legend2.TitleForeColor = System.Drawing.Color.Transparent;
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(9, 201);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "Udc";
            series3.ToolTip = "\"#VALX,#VALY\"";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(572, 162);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart3.BackColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea3.AxisX.Minimum = 1D;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LogarithmBase = 5D;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea3.AxisY.Minimum = 10D;
            chartArea3.CursorX.IsUserEnabled = true;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 75F;
            chartArea3.InnerPlotPosition.Width = 88F;
            chartArea3.InnerPlotPosition.X = 9.5F;
            chartArea3.InnerPlotPosition.Y = 5F;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 94F;
            chartArea3.Position.Width = 100F;
            chartArea3.Position.Y = 3F;
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.DockedToChartArea = "ChartArea1";
            legend3.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.MaximumAutoSize = 30F;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(9, 377);
            this.chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series4.Name = "Vel";
            series4.ToolTip = "\"#VALX,#VALY\"";
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(572, 142);
            this.chart3.TabIndex = 10;
            this.chart3.Text = "chart3";
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Clear.Location = new System.Drawing.Point(361, 28);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(64, 78);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "清空";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // textBox_Test
            // 
            this.textBox_Test.Location = new System.Drawing.Point(10, 21);
            this.textBox_Test.Multiline = true;
            this.textBox_Test.Name = "textBox_Test";
            this.textBox_Test.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Test.Size = new System.Drawing.Size(339, 95);
            this.textBox_Test.TabIndex = 0;
            // 
            // button_ControlSend
            // 
            this.button_ControlSend.Location = new System.Drawing.Point(313, 83);
            this.button_ControlSend.Name = "button_ControlSend";
            this.button_ControlSend.Size = new System.Drawing.Size(80, 30);
            this.button_ControlSend.TabIndex = 3;
            this.button_ControlSend.Text = "发送";
            this.button_ControlSend.UseVisualStyleBackColor = true;
            this.button_ControlSend.Click += new System.EventHandler(this.button_ControlSend_Click);
            // 
            // textBox_CanID
            // 
            this.textBox_CanID.Enabled = false;
            this.textBox_CanID.Location = new System.Drawing.Point(162, 35);
            this.textBox_CanID.Name = "textBox_CanID";
            this.textBox_CanID.Size = new System.Drawing.Size(100, 26);
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
            this.numericUpDown_Vel.Location = new System.Drawing.Point(162, 86);
            this.numericUpDown_Vel.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numericUpDown_Vel.Name = "numericUpDown_Vel";
            this.numericUpDown_Vel.Size = new System.Drawing.Size(102, 26);
            this.numericUpDown_Vel.TabIndex = 1;
            this.numericUpDown_Vel.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label11.Location = new System.Drawing.Point(32, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "CAN ID(标准帧)：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label10.Location = new System.Drawing.Point(32, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "速度 Vel-1 (rpm)：";
            // 
            // groupBox_Draw
            // 
            this.groupBox_Draw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Draw.AutoSize = true;
            this.groupBox_Draw.Controls.Add(this.chart1);
            this.groupBox_Draw.Controls.Add(this.chart3);
            this.groupBox_Draw.Controls.Add(this.chart2);
            this.groupBox_Draw.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.groupBox_Draw.Location = new System.Drawing.Point(619, 23);
            this.groupBox_Draw.Name = "groupBox_Draw";
            this.groupBox_Draw.Size = new System.Drawing.Size(587, 544);
            this.groupBox_Draw.TabIndex = 11;
            this.groupBox_Draw.TabStop = false;
            this.groupBox_Draw.Text = "绘图";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_ErrNum);
            this.groupBox2.Controls.Add(this.button_Clear);
            this.groupBox2.Controls.Add(this.label_Buffersize);
            this.groupBox2.Controls.Add(this.textBox_Test);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.groupBox2.Location = new System.Drawing.Point(16, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 121);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Rec);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.button_ControlSend2);
            this.groupBox3.Controls.Add(this.button_ControlSend);
            this.groupBox3.Controls.Add(this.numericUpDown_Vel2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.numericUpDown_Vel);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox_CanID);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.groupBox3.Location = new System.Drawing.Point(16, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 178);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "控制";
            // 
            // button_Rec
            // 
            this.button_Rec.Location = new System.Drawing.Point(443, 83);
            this.button_Rec.Name = "button_Rec";
            this.button_Rec.Size = new System.Drawing.Size(80, 71);
            this.button_Rec.TabIndex = 7;
            this.button_Rec.Text = "重新记录";
            this.button_Rec.UseVisualStyleBackColor = true;
            this.button_Rec.Click += new System.EventHandler(this.button_Rec_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_NoRec);
            this.panel1.Controls.Add(this.radioButton_Rec);
            this.panel1.Location = new System.Drawing.Point(414, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 29);
            this.panel1.TabIndex = 6;
            // 
            // radioButton_NoRec
            // 
            this.radioButton_NoRec.AutoSize = true;
            this.radioButton_NoRec.Location = new System.Drawing.Point(65, 2);
            this.radioButton_NoRec.Name = "radioButton_NoRec";
            this.radioButton_NoRec.Size = new System.Drawing.Size(41, 24);
            this.radioButton_NoRec.TabIndex = 5;
            this.radioButton_NoRec.TabStop = true;
            this.radioButton_NoRec.Text = "否";
            this.radioButton_NoRec.UseVisualStyleBackColor = true;
            this.radioButton_NoRec.CheckedChanged += new System.EventHandler(this.radioButton_NoRec_CheckedChanged);
            // 
            // radioButton_Rec
            // 
            this.radioButton_Rec.AutoSize = true;
            this.radioButton_Rec.Location = new System.Drawing.Point(12, 2);
            this.radioButton_Rec.Name = "radioButton_Rec";
            this.radioButton_Rec.Size = new System.Drawing.Size(41, 24);
            this.radioButton_Rec.TabIndex = 5;
            this.radioButton_Rec.TabStop = true;
            this.radioButton_Rec.Text = "是";
            this.radioButton_Rec.UseVisualStyleBackColor = true;
            this.radioButton_Rec.CheckedChanged += new System.EventHandler(this.radioButton_Rec_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "记录数据：";
            // 
            // button_ControlSend2
            // 
            this.button_ControlSend2.Location = new System.Drawing.Point(313, 124);
            this.button_ControlSend2.Name = "button_ControlSend2";
            this.button_ControlSend2.Size = new System.Drawing.Size(80, 30);
            this.button_ControlSend2.TabIndex = 3;
            this.button_ControlSend2.Text = "发送";
            this.button_ControlSend2.UseVisualStyleBackColor = true;
            this.button_ControlSend2.Click += new System.EventHandler(this.button_ControlSend2_Click);
            // 
            // numericUpDown_Vel2
            // 
            this.numericUpDown_Vel2.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Vel2.Location = new System.Drawing.Point(162, 127);
            this.numericUpDown_Vel2.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numericUpDown_Vel2.Name = "numericUpDown_Vel2";
            this.numericUpDown_Vel2.Size = new System.Drawing.Size(102, 26);
            this.numericUpDown_Vel2.TabIndex = 1;
            this.numericUpDown_Vel2.ThousandsSeparator = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label13.Location = new System.Drawing.Point(32, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "速度 Vel-2 (rpm)：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1218, 581);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_Draw);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_set);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimumSize = new System.Drawing.Size(1230, 620);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Svpwm-Can";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_set.ResumeLayout(false);
            this.groupBox_set.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Vel)).EndInit();
            this.groupBox_Draw.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Vel2)).EndInit();
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
        private System.Windows.Forms.TextBox textBox_Test;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_CanID;
        private System.Windows.Forms.NumericUpDown numericUpDown_Vel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_ControlSend;
        private System.Windows.Forms.Button button_Ia;
        private System.Windows.Forms.Button button_Ic;
        private System.Windows.Forms.Button button_Udc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_Vector;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.GroupBox groupBox_Draw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_NoRec;
        private System.Windows.Forms.RadioButton radioButton_Rec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_ControlSend2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Vel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_Rec;
    }
}

