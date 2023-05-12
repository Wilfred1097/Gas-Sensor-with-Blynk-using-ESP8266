namespace MQ2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_comport = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.load_data = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimatorDuration = 500;
            this.circularProgressBar1.AnimatorFunction = ((WinFormAnimation.Functions.Function)(resources.GetObject("circularProgressBar1.AnimatorFunction")));
            this.circularProgressBar1.BackColor = System.Drawing.Color.White;
            this.circularProgressBar1.Caption = null;
            this.circularProgressBar1.CaptionMargin = 3;
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.circularProgressBar1.InnerCircleColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerCircleMargin = 4;
            this.circularProgressBar1.InnerCircleWidth = 3;
            this.circularProgressBar1.Location = new System.Drawing.Point(22, 26);
            this.circularProgressBar1.MaxValue = 3000F;
            this.circularProgressBar1.MinValue = 0F;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterCircleColor = System.Drawing.Color.DeepSkyBlue;
            this.circularProgressBar1.OuterCircleMargin = 0;
            this.circularProgressBar1.OuterCircleWidth = 1;
            this.circularProgressBar1.ProgressCircleColor = System.Drawing.Color.DeepSkyBlue;
            this.circularProgressBar1.ProgressCircleStartAngle = 90;
            this.circularProgressBar1.ProgressCircleWidth = 20;
            this.circularProgressBar1.Size = new System.Drawing.Size(120, 120);
            this.circularProgressBar1.SubText = null;
            this.circularProgressBar1.SubTextColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.SupSubFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.SupText = "";
            this.circularProgressBar1.SupTextColor = System.Drawing.Color.Black;
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.Value = 2000F;
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimatorDuration = 500;
            this.circularProgressBar2.AnimatorFunction = ((WinFormAnimation.Functions.Function)(resources.GetObject("circularProgressBar2.AnimatorFunction")));
            this.circularProgressBar2.BackColor = System.Drawing.Color.White;
            this.circularProgressBar2.Caption = null;
            this.circularProgressBar2.CaptionMargin = 3;
            this.circularProgressBar2.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar2.InnerCircleColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.InnerCircleMargin = 4;
            this.circularProgressBar2.InnerCircleWidth = 3;
            this.circularProgressBar2.Location = new System.Drawing.Point(26, 28);
            this.circularProgressBar2.MaxValue = 200F;
            this.circularProgressBar2.MinValue = 0F;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterCircleColor = System.Drawing.Color.Orange;
            this.circularProgressBar2.OuterCircleMargin = 0;
            this.circularProgressBar2.OuterCircleWidth = 1;
            this.circularProgressBar2.ProgressCircleColor = System.Drawing.Color.Orange;
            this.circularProgressBar2.ProgressCircleStartAngle = 90;
            this.circularProgressBar2.ProgressCircleWidth = 20;
            this.circularProgressBar2.Size = new System.Drawing.Size(120, 120);
            this.circularProgressBar2.SubText = null;
            this.circularProgressBar2.SubTextColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.SupSubFont = new System.Drawing.Font("Microsoft Sans Serif", 4.125F);
            this.circularProgressBar2.SupText = null;
            this.circularProgressBar2.SupTextColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.TabIndex = 16;
            this.circularProgressBar2.Value = 150F;
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.AnimatorDuration = 500;
            this.circularProgressBar3.AnimatorFunction = ((WinFormAnimation.Functions.Function)(resources.GetObject("circularProgressBar3.AnimatorFunction")));
            this.circularProgressBar3.BackColor = System.Drawing.Color.White;
            this.circularProgressBar3.Caption = null;
            this.circularProgressBar3.CaptionMargin = 3;
            this.circularProgressBar3.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar3.InnerCircleColor = System.Drawing.Color.Transparent;
            this.circularProgressBar3.InnerCircleMargin = 4;
            this.circularProgressBar3.InnerCircleWidth = 3;
            this.circularProgressBar3.Location = new System.Drawing.Point(28, 26);
            this.circularProgressBar3.MaxValue = 100F;
            this.circularProgressBar3.MinValue = 0F;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterCircleColor = System.Drawing.Color.OliveDrab;
            this.circularProgressBar3.OuterCircleMargin = 0;
            this.circularProgressBar3.OuterCircleWidth = 1;
            this.circularProgressBar3.ProgressCircleColor = System.Drawing.Color.OliveDrab;
            this.circularProgressBar3.ProgressCircleStartAngle = 90;
            this.circularProgressBar3.ProgressCircleWidth = 20;
            this.circularProgressBar3.Size = new System.Drawing.Size(120, 120);
            this.circularProgressBar3.SubText = null;
            this.circularProgressBar3.SubTextColor = System.Drawing.Color.Gray;
            this.circularProgressBar3.SupSubFont = new System.Drawing.Font("Microsoft Sans Serif", 4.125F);
            this.circularProgressBar3.SupText = null;
            this.circularProgressBar3.SupTextColor = System.Drawing.Color.Gray;
            this.circularProgressBar3.TabIndex = 17;
            this.circularProgressBar3.Value = 80F;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "2000";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.Location = new System.Drawing.Point(230, 12);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Maximum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(15, 15);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 7;
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(134, 116);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(77, 23);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "CLOSE";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_open.Location = new System.Drawing.Point(27, 116);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(77, 23);
            this.button_open.TabIndex = 5;
            this.button_open.Text = "OPEN";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudrate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(117, 63);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(94, 24);
            this.comboBox_baudrate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "BAUD RATE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "COM PORT:";
            // 
            // comboBox_comport
            // 
            this.comboBox_comport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_comport.FormattingEnabled = true;
            this.comboBox_comport.Location = new System.Drawing.Point(117, 28);
            this.comboBox_comport.Name = "comboBox_comport";
            this.comboBox_comport.Size = new System.Drawing.Size(94, 24);
            this.comboBox_comport.TabIndex = 3;
            this.comboBox_comport.DropDown += new System.EventHandler(this.comboBox_comport_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_comport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_baudrate);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 167);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM  PORT SETTINGS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.circularProgressBar1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(266, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 167);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LPG PPM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.circularProgressBar2);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(439, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 167);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CO PPM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "150";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.circularProgressBar3);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(612, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 167);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SMOKE PPM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "100";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(-30, 177);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series7.BorderColor = System.Drawing.Color.LightBlue;
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.DeepSkyBlue;
            series7.Legend = "Legend1";
            series7.Name = "LPG PPM";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.Orange;
            series8.Legend = "Legend1";
            series8.Name = "CO PPM";
            series9.ChartArea = "ChartArea1";
            series9.Color = System.Drawing.Color.OliveDrab;
            series9.Legend = "Legend1";
            series9.Name = "SMOKE PPM";
            series9.Points.Add(dataPoint3);
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(809, 340);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "chart1";
            // 
            // load_data
            // 
            this.load_data.Location = new System.Drawing.Point(640, 456);
            this.load_data.Name = "load_data";
            this.load_data.Size = new System.Drawing.Size(120, 23);
            this.load_data.TabIndex = 29;
            this.load_data.Text = "REFRESH DATA";
            this.load_data.UseVisualStyleBackColor = true;
            this.load_data.Click += new System.EventHandler(this.load_data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 517);
            this.Controls.Add(this.load_data);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MQ2 Gas Sensor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_comport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button load_data;
    }
}

