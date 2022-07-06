namespace DroptestApp
{
    partial class MainBoard
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
            this.NavPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IUDLABlabel = new System.Windows.Forms.Label();
            this.MagnetSensorLabel = new System.Windows.Forms.Label();
            this.BotSensorLabel = new System.Windows.Forms.Label();
            this.MagnetSensorPic = new System.Windows.Forms.PictureBox();
            this.TopSensorLabel = new System.Windows.Forms.Label();
            this.TopSensorPic = new System.Windows.Forms.PictureBox();
            this.BotSensorPic = new System.Windows.Forms.PictureBox();
            this.PlotFigure = new OxyPlot.WindowsForms.PlotView();
            this.UpBtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.MagOnBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SensorCombo = new System.Windows.Forms.ComboBox();
            this.SensorsLabel = new System.Windows.Forms.Label();
            this.COMCombo = new System.Windows.Forms.ComboBox();
            this.COMLabel = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.SpeedUpdown = new System.Windows.Forms.NumericUpDown();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.ReportGroup = new System.Windows.Forms.GroupBox();
            this.MaxForceText = new System.Windows.Forms.TextBox();
            this.MaxDecelerationText = new System.Windows.Forms.TextBox();
            this.MaxForceLabel = new System.Windows.Forms.Label();
            this.MaxDecelerationLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SensorParameterGroup = new System.Windows.Forms.GroupBox();
            this.BitDepthText = new System.Windows.Forms.TextBox();
            this.MeasuringTimesText = new System.Windows.Forms.TextBox();
            this.SamplingRateText = new System.Windows.Forms.TextBox();
            this.BitDepthLabel = new System.Windows.Forms.Label();
            this.MeasuringTimesLabel = new System.Windows.Forms.Label();
            this.SamplingRateLabel = new System.Windows.Forms.Label();
            this.OtherSpecsGroup = new System.Windows.Forms.GroupBox();
            this.HumidityText = new System.Windows.Forms.TextBox();
            this.TemperatureText = new System.Windows.Forms.TextBox();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.SensorsStatusGroup = new System.Windows.Forms.GroupBox();
            this.FindBtn = new System.Windows.Forms.Button();
            this.RecordPanel = new System.Windows.Forms.Panel();
            this.MagOffBtn = new System.Windows.Forms.Button();
            this.ExportGroup = new System.Windows.Forms.GroupBox();
            this.NewIDBtn = new System.Windows.Forms.Button();
            this.TestIDText = new System.Windows.Forms.TextBox();
            this.CustomerText = new System.Windows.Forms.TextBox();
            this.TestIDLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.NavPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagnetSensorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSensorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotSensorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpdown)).BeginInit();
            this.ReportGroup.SuspendLayout();
            this.SensorParameterGroup.SuspendLayout();
            this.OtherSpecsGroup.SuspendLayout();
            this.SensorsStatusGroup.SuspendLayout();
            this.RecordPanel.SuspendLayout();
            this.ExportGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NavPanel.Controls.Add(this.LogoPanel);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(1080, 61);
            this.NavPanel.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.AutoSize = true;
            this.LogoPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Controls.Add(this.IUDLABlabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(1080, 61);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DroptestApp.Properties.Resources.icons8_redux_50;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // IUDLABlabel
            // 
            this.IUDLABlabel.AutoSize = true;
            this.IUDLABlabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IUDLABlabel.ForeColor = System.Drawing.Color.White;
            this.IUDLABlabel.Location = new System.Drawing.Point(65, 12);
            this.IUDLABlabel.Name = "IUDLABlabel";
            this.IUDLABlabel.Size = new System.Drawing.Size(119, 37);
            this.IUDLABlabel.TabIndex = 0;
            this.IUDLABlabel.Text = "IUD Lab";
            // 
            // MagnetSensorLabel
            // 
            this.MagnetSensorLabel.AutoSize = true;
            this.MagnetSensorLabel.Location = new System.Drawing.Point(184, 72);
            this.MagnetSensorLabel.Name = "MagnetSensorLabel";
            this.MagnetSensorLabel.Size = new System.Drawing.Size(60, 20);
            this.MagnetSensorLabel.TabIndex = 5;
            this.MagnetSensorLabel.Text = "Magnet";
            // 
            // BotSensorLabel
            // 
            this.BotSensorLabel.AutoSize = true;
            this.BotSensorLabel.Location = new System.Drawing.Point(121, 72);
            this.BotSensorLabel.Name = "BotSensorLabel";
            this.BotSensorLabel.Size = new System.Drawing.Size(32, 20);
            this.BotSensorLabel.TabIndex = 4;
            this.BotSensorLabel.Text = "Bot";
            // 
            // MagnetSensorPic
            // 
            this.MagnetSensorPic.Image = global::DroptestApp.Properties.Resources.circle_gray;
            this.MagnetSensorPic.Location = new System.Drawing.Point(199, 34);
            this.MagnetSensorPic.Name = "MagnetSensorPic";
            this.MagnetSensorPic.Size = new System.Drawing.Size(32, 32);
            this.MagnetSensorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MagnetSensorPic.TabIndex = 2;
            this.MagnetSensorPic.TabStop = false;
            // 
            // TopSensorLabel
            // 
            this.TopSensorLabel.AutoSize = true;
            this.TopSensorLabel.Location = new System.Drawing.Point(46, 72);
            this.TopSensorLabel.Name = "TopSensorLabel";
            this.TopSensorLabel.Size = new System.Drawing.Size(34, 20);
            this.TopSensorLabel.TabIndex = 3;
            this.TopSensorLabel.Text = "Top";
            // 
            // TopSensorPic
            // 
            this.TopSensorPic.Image = global::DroptestApp.Properties.Resources.circle_gray;
            this.TopSensorPic.Location = new System.Drawing.Point(46, 34);
            this.TopSensorPic.Name = "TopSensorPic";
            this.TopSensorPic.Size = new System.Drawing.Size(32, 32);
            this.TopSensorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TopSensorPic.TabIndex = 0;
            this.TopSensorPic.TabStop = false;
            // 
            // BotSensorPic
            // 
            this.BotSensorPic.Image = global::DroptestApp.Properties.Resources.circle_gray;
            this.BotSensorPic.Location = new System.Drawing.Point(121, 34);
            this.BotSensorPic.Name = "BotSensorPic";
            this.BotSensorPic.Size = new System.Drawing.Size(32, 32);
            this.BotSensorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotSensorPic.TabIndex = 1;
            this.BotSensorPic.TabStop = false;
            // 
            // PlotFigure
            // 
            this.PlotFigure.BackColor = System.Drawing.Color.White;
            this.PlotFigure.Location = new System.Drawing.Point(0, 134);
            this.PlotFigure.Name = "PlotFigure";
            this.PlotFigure.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlotFigure.Size = new System.Drawing.Size(1080, 367);
            this.PlotFigure.TabIndex = 1;
            this.PlotFigure.Text = "PlotFigure";
            this.PlotFigure.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PlotFigure.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PlotFigure.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // UpBtn
            // 
            this.UpBtn.Enabled = false;
            this.UpBtn.Image = global::DroptestApp.Properties.Resources.caret_arrow_up;
            this.UpBtn.Location = new System.Drawing.Point(723, 23);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(50, 50);
            this.UpBtn.TabIndex = 2;
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBtn_MouseDown);
            this.UpBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpBtn_MouseUp);
            // 
            // DownBtn
            // 
            this.DownBtn.Enabled = false;
            this.DownBtn.Image = global::DroptestApp.Properties.Resources.sort_down;
            this.DownBtn.Location = new System.Drawing.Point(723, 78);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(50, 50);
            this.DownBtn.TabIndex = 3;
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownBtn_MouseDown);
            this.DownBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DownBtn_MouseUp);
            // 
            // MagOnBtn
            // 
            this.MagOnBtn.Enabled = false;
            this.MagOnBtn.Location = new System.Drawing.Point(515, 66);
            this.MagOnBtn.Name = "MagOnBtn";
            this.MagOnBtn.Size = new System.Drawing.Size(92, 28);
            this.MagOnBtn.TabIndex = 4;
            this.MagOnBtn.Text = "Mag On";
            this.MagOnBtn.UseVisualStyleBackColor = true;
            this.MagOnBtn.Click += new System.EventHandler(this.MagOnBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(613, 100);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(92, 28);
            this.StopBtn.TabIndex = 5;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Enabled = false;
            this.StartBtn.Location = new System.Drawing.Point(613, 65);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(92, 30);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // SensorCombo
            // 
            this.SensorCombo.FormattingEnabled = true;
            this.SensorCombo.Location = new System.Drawing.Point(83, 29);
            this.SensorCombo.Name = "SensorCombo";
            this.SensorCombo.Size = new System.Drawing.Size(310, 28);
            this.SensorCombo.TabIndex = 7;
            // 
            // SensorsLabel
            // 
            this.SensorsLabel.AutoSize = true;
            this.SensorsLabel.Location = new System.Drawing.Point(6, 35);
            this.SensorsLabel.Name = "SensorsLabel";
            this.SensorsLabel.Size = new System.Drawing.Size(62, 20);
            this.SensorsLabel.TabIndex = 8;
            this.SensorsLabel.Text = "Sensors:";
            // 
            // COMCombo
            // 
            this.COMCombo.FormattingEnabled = true;
            this.COMCombo.Location = new System.Drawing.Point(83, 66);
            this.COMCombo.Name = "COMCombo";
            this.COMCombo.Size = new System.Drawing.Size(310, 28);
            this.COMCombo.TabIndex = 9;
            // 
            // COMLabel
            // 
            this.COMLabel.AutoSize = true;
            this.COMLabel.Location = new System.Drawing.Point(6, 70);
            this.COMLabel.Name = "COMLabel";
            this.COMLabel.Size = new System.Drawing.Size(49, 20);
            this.COMLabel.TabIndex = 10;
            this.COMLabel.Text = "COM: ";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(399, 65);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(94, 30);
            this.ConnectBtn.TabIndex = 11;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // SpeedUpdown
            // 
            this.SpeedUpdown.Location = new System.Drawing.Point(613, 32);
            this.SpeedUpdown.Name = "SpeedUpdown";
            this.SpeedUpdown.Size = new System.Drawing.Size(92, 27);
            this.SpeedUpdown.TabIndex = 12;
            this.SpeedUpdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpeedUpdown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SpeedUpdown.ValueChanged += new System.EventHandler(this.SpeedUpdown_ValueChanged);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(515, 35);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(80, 20);
            this.SpeedLabel.TabIndex = 13;
            this.SpeedLabel.Text = "Speed (%):";
            // 
            // ReportGroup
            // 
            this.ReportGroup.Controls.Add(this.MaxForceText);
            this.ReportGroup.Controls.Add(this.MaxDecelerationText);
            this.ReportGroup.Controls.Add(this.MaxForceLabel);
            this.ReportGroup.Controls.Add(this.MaxDecelerationLabel);
            this.ReportGroup.Location = new System.Drawing.Point(441, 520);
            this.ReportGroup.Name = "ReportGroup";
            this.ReportGroup.Size = new System.Drawing.Size(240, 128);
            this.ReportGroup.TabIndex = 18;
            this.ReportGroup.TabStop = false;
            this.ReportGroup.Text = "Report";
            // 
            // MaxForceText
            // 
            this.MaxForceText.BackColor = System.Drawing.Color.White;
            this.MaxForceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxForceText.ForeColor = System.Drawing.Color.Black;
            this.MaxForceText.Location = new System.Drawing.Point(168, 59);
            this.MaxForceText.Name = "MaxForceText";
            this.MaxForceText.ReadOnly = true;
            this.MaxForceText.Size = new System.Drawing.Size(61, 20);
            this.MaxForceText.TabIndex = 3;
            this.MaxForceText.Text = "0";
            // 
            // MaxDecelerationText
            // 
            this.MaxDecelerationText.BackColor = System.Drawing.Color.White;
            this.MaxDecelerationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxDecelerationText.ForeColor = System.Drawing.Color.Black;
            this.MaxDecelerationText.Location = new System.Drawing.Point(168, 26);
            this.MaxDecelerationText.Name = "MaxDecelerationText";
            this.MaxDecelerationText.ReadOnly = true;
            this.MaxDecelerationText.Size = new System.Drawing.Size(61, 20);
            this.MaxDecelerationText.TabIndex = 2;
            this.MaxDecelerationText.Text = "1";
            // 
            // MaxForceLabel
            // 
            this.MaxForceLabel.AutoSize = true;
            this.MaxForceLabel.Location = new System.Drawing.Point(6, 59);
            this.MaxForceLabel.Name = "MaxForceLabel";
            this.MaxForceLabel.Size = new System.Drawing.Size(105, 20);
            this.MaxForceLabel.TabIndex = 1;
            this.MaxForceLabel.Text = "Max Force (N):";
            // 
            // MaxDecelerationLabel
            // 
            this.MaxDecelerationLabel.AutoSize = true;
            this.MaxDecelerationLabel.Location = new System.Drawing.Point(6, 25);
            this.MaxDecelerationLabel.Name = "MaxDecelerationLabel";
            this.MaxDecelerationLabel.Size = new System.Drawing.Size(156, 20);
            this.MaxDecelerationLabel.TabIndex = 0;
            this.MaxDecelerationLabel.Text = "Max Deceleration (g): ";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(280, 91);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(95, 28);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SensorParameterGroup
            // 
            this.SensorParameterGroup.Controls.Add(this.BitDepthText);
            this.SensorParameterGroup.Controls.Add(this.MeasuringTimesText);
            this.SensorParameterGroup.Controls.Add(this.SamplingRateText);
            this.SensorParameterGroup.Controls.Add(this.BitDepthLabel);
            this.SensorParameterGroup.Controls.Add(this.MeasuringTimesLabel);
            this.SensorParameterGroup.Controls.Add(this.SamplingRateLabel);
            this.SensorParameterGroup.Location = new System.Drawing.Point(12, 520);
            this.SensorParameterGroup.Name = "SensorParameterGroup";
            this.SensorParameterGroup.Size = new System.Drawing.Size(225, 128);
            this.SensorParameterGroup.TabIndex = 19;
            this.SensorParameterGroup.TabStop = false;
            this.SensorParameterGroup.Text = "Sensor Parameters";
            // 
            // BitDepthText
            // 
            this.BitDepthText.Location = new System.Drawing.Point(161, 91);
            this.BitDepthText.Name = "BitDepthText";
            this.BitDepthText.Size = new System.Drawing.Size(54, 27);
            this.BitDepthText.TabIndex = 5;
            this.BitDepthText.Text = "16";
            // 
            // MeasuringTimesText
            // 
            this.MeasuringTimesText.Location = new System.Drawing.Point(161, 58);
            this.MeasuringTimesText.Name = "MeasuringTimesText";
            this.MeasuringTimesText.Size = new System.Drawing.Size(54, 27);
            this.MeasuringTimesText.TabIndex = 4;
            this.MeasuringTimesText.Text = "5";
            // 
            // SamplingRateText
            // 
            this.SamplingRateText.Location = new System.Drawing.Point(161, 24);
            this.SamplingRateText.Name = "SamplingRateText";
            this.SamplingRateText.Size = new System.Drawing.Size(54, 27);
            this.SamplingRateText.TabIndex = 3;
            this.SamplingRateText.Text = "16000";
            // 
            // BitDepthLabel
            // 
            this.BitDepthLabel.AutoSize = true;
            this.BitDepthLabel.Location = new System.Drawing.Point(6, 94);
            this.BitDepthLabel.Name = "BitDepthLabel";
            this.BitDepthLabel.Size = new System.Drawing.Size(113, 20);
            this.BitDepthLabel.TabIndex = 2;
            this.BitDepthLabel.Text = "Bit Depth (bits):";
            // 
            // MeasuringTimesLabel
            // 
            this.MeasuringTimesLabel.AutoSize = true;
            this.MeasuringTimesLabel.Location = new System.Drawing.Point(6, 59);
            this.MeasuringTimesLabel.Name = "MeasuringTimesLabel";
            this.MeasuringTimesLabel.Size = new System.Drawing.Size(144, 20);
            this.MeasuringTimesLabel.TabIndex = 1;
            this.MeasuringTimesLabel.Text = "Measuring Times (s):";
            // 
            // SamplingRateLabel
            // 
            this.SamplingRateLabel.AutoSize = true;
            this.SamplingRateLabel.Location = new System.Drawing.Point(6, 25);
            this.SamplingRateLabel.Name = "SamplingRateLabel";
            this.SamplingRateLabel.Size = new System.Drawing.Size(145, 20);
            this.SamplingRateLabel.TabIndex = 0;
            this.SamplingRateLabel.Text = "Sampling Rate (Hz): ";
            // 
            // OtherSpecsGroup
            // 
            this.OtherSpecsGroup.Controls.Add(this.HumidityText);
            this.OtherSpecsGroup.Controls.Add(this.TemperatureText);
            this.OtherSpecsGroup.Controls.Add(this.HumidityLabel);
            this.OtherSpecsGroup.Controls.Add(this.TemperatureLabel);
            this.OtherSpecsGroup.Location = new System.Drawing.Point(243, 520);
            this.OtherSpecsGroup.Name = "OtherSpecsGroup";
            this.OtherSpecsGroup.Size = new System.Drawing.Size(192, 128);
            this.OtherSpecsGroup.TabIndex = 20;
            this.OtherSpecsGroup.TabStop = false;
            this.OtherSpecsGroup.Text = "Other Specs";
            // 
            // HumidityText
            // 
            this.HumidityText.Location = new System.Drawing.Point(132, 56);
            this.HumidityText.Name = "HumidityText";
            this.HumidityText.Size = new System.Drawing.Size(50, 27);
            this.HumidityText.TabIndex = 5;
            this.HumidityText.Text = "1";
            // 
            // TemperatureText
            // 
            this.TemperatureText.Location = new System.Drawing.Point(132, 22);
            this.TemperatureText.Name = "TemperatureText";
            this.TemperatureText.Size = new System.Drawing.Size(50, 27);
            this.TemperatureText.TabIndex = 4;
            this.TemperatureText.Text = "1";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Location = new System.Drawing.Point(6, 59);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(99, 20);
            this.HumidityLabel.TabIndex = 2;
            this.HumidityLabel.Text = "Humidity (%):";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(6, 25);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(119, 20);
            this.TemperatureLabel.TabIndex = 1;
            this.TemperatureLabel.Text = "Temperature (C):";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(399, 100);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(94, 28);
            this.DisconnectBtn.TabIndex = 21;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // SensorsStatusGroup
            // 
            this.SensorsStatusGroup.Controls.Add(this.MagnetSensorLabel);
            this.SensorsStatusGroup.Controls.Add(this.MagnetSensorPic);
            this.SensorsStatusGroup.Controls.Add(this.BotSensorPic);
            this.SensorsStatusGroup.Controls.Add(this.BotSensorLabel);
            this.SensorsStatusGroup.Controls.Add(this.TopSensorPic);
            this.SensorsStatusGroup.Controls.Add(this.TopSensorLabel);
            this.SensorsStatusGroup.Location = new System.Drawing.Point(795, 19);
            this.SensorsStatusGroup.Name = "SensorsStatusGroup";
            this.SensorsStatusGroup.Size = new System.Drawing.Size(269, 109);
            this.SensorsStatusGroup.TabIndex = 15;
            this.SensorsStatusGroup.TabStop = false;
            this.SensorsStatusGroup.Text = "Sensors Status";
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(399, 29);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(94, 30);
            this.FindBtn.TabIndex = 22;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // RecordPanel
            // 
            this.RecordPanel.AutoSize = true;
            this.RecordPanel.Controls.Add(this.MagOffBtn);
            this.RecordPanel.Controls.Add(this.ExportGroup);
            this.RecordPanel.Controls.Add(this.FindBtn);
            this.RecordPanel.Controls.Add(this.DisconnectBtn);
            this.RecordPanel.Controls.Add(this.OtherSpecsGroup);
            this.RecordPanel.Controls.Add(this.SensorParameterGroup);
            this.RecordPanel.Controls.Add(this.ReportGroup);
            this.RecordPanel.Controls.Add(this.SensorsStatusGroup);
            this.RecordPanel.Controls.Add(this.SpeedLabel);
            this.RecordPanel.Controls.Add(this.SpeedUpdown);
            this.RecordPanel.Controls.Add(this.ConnectBtn);
            this.RecordPanel.Controls.Add(this.COMLabel);
            this.RecordPanel.Controls.Add(this.COMCombo);
            this.RecordPanel.Controls.Add(this.SensorsLabel);
            this.RecordPanel.Controls.Add(this.SensorCombo);
            this.RecordPanel.Controls.Add(this.StartBtn);
            this.RecordPanel.Controls.Add(this.StopBtn);
            this.RecordPanel.Controls.Add(this.MagOnBtn);
            this.RecordPanel.Controls.Add(this.DownBtn);
            this.RecordPanel.Controls.Add(this.UpBtn);
            this.RecordPanel.Controls.Add(this.PlotFigure);
            this.RecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordPanel.Location = new System.Drawing.Point(0, 61);
            this.RecordPanel.Name = "RecordPanel";
            this.RecordPanel.Size = new System.Drawing.Size(1080, 660);
            this.RecordPanel.TabIndex = 23;
            // 
            // MagOffBtn
            // 
            this.MagOffBtn.Enabled = false;
            this.MagOffBtn.Location = new System.Drawing.Point(515, 100);
            this.MagOffBtn.Name = "MagOffBtn";
            this.MagOffBtn.Size = new System.Drawing.Size(92, 28);
            this.MagOffBtn.TabIndex = 28;
            this.MagOffBtn.Text = "Mag Off";
            this.MagOffBtn.UseVisualStyleBackColor = true;
            this.MagOffBtn.Click += new System.EventHandler(this.MagOffBtn_Click);
            // 
            // ExportGroup
            // 
            this.ExportGroup.Controls.Add(this.NewIDBtn);
            this.ExportGroup.Controls.Add(this.TestIDText);
            this.ExportGroup.Controls.Add(this.CustomerText);
            this.ExportGroup.Controls.Add(this.TestIDLabel);
            this.ExportGroup.Controls.Add(this.CustomerLabel);
            this.ExportGroup.Controls.Add(this.SaveBtn);
            this.ExportGroup.Location = new System.Drawing.Point(687, 520);
            this.ExportGroup.Name = "ExportGroup";
            this.ExportGroup.Size = new System.Drawing.Size(381, 128);
            this.ExportGroup.TabIndex = 27;
            this.ExportGroup.TabStop = false;
            this.ExportGroup.Text = "Export";
            // 
            // NewIDBtn
            // 
            this.NewIDBtn.Location = new System.Drawing.Point(280, 56);
            this.NewIDBtn.Name = "NewIDBtn";
            this.NewIDBtn.Size = new System.Drawing.Size(95, 29);
            this.NewIDBtn.TabIndex = 30;
            this.NewIDBtn.Text = "New ID";
            this.NewIDBtn.UseVisualStyleBackColor = true;
            this.NewIDBtn.Click += new System.EventHandler(this.NewIDBtn_Click);
            // 
            // TestIDText
            // 
            this.TestIDText.BackColor = System.Drawing.Color.White;
            this.TestIDText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TestIDText.ForeColor = System.Drawing.Color.Black;
            this.TestIDText.Location = new System.Drawing.Point(92, 63);
            this.TestIDText.Name = "TestIDText";
            this.TestIDText.ReadOnly = true;
            this.TestIDText.Size = new System.Drawing.Size(164, 20);
            this.TestIDText.TabIndex = 29;
            // 
            // CustomerText
            // 
            this.CustomerText.Location = new System.Drawing.Point(92, 24);
            this.CustomerText.Name = "CustomerText";
            this.CustomerText.Size = new System.Drawing.Size(283, 27);
            this.CustomerText.TabIndex = 28;
            // 
            // TestIDLabel
            // 
            this.TestIDLabel.AutoSize = true;
            this.TestIDLabel.Location = new System.Drawing.Point(11, 63);
            this.TestIDLabel.Name = "TestIDLabel";
            this.TestIDLabel.Size = new System.Drawing.Size(57, 20);
            this.TestIDLabel.TabIndex = 25;
            this.TestIDLabel.Text = "Test ID:";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(11, 27);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(75, 20);
            this.CustomerLabel.TabIndex = 23;
            this.CustomerLabel.Text = "Customer:";
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 721);
            this.Controls.Add(this.RecordPanel);
            this.Controls.Add(this.NavPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1098, 768);
            this.Name = "MainBoard";
            this.Text = "MainBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainBoard_FormClosing);
            this.Load += new System.EventHandler(this.MainBoard_Load);
            this.NavPanel.ResumeLayout(false);
            this.NavPanel.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagnetSensorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSensorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotSensorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpdown)).EndInit();
            this.ReportGroup.ResumeLayout(false);
            this.ReportGroup.PerformLayout();
            this.SensorParameterGroup.ResumeLayout(false);
            this.SensorParameterGroup.PerformLayout();
            this.OtherSpecsGroup.ResumeLayout(false);
            this.OtherSpecsGroup.PerformLayout();
            this.SensorsStatusGroup.ResumeLayout(false);
            this.SensorsStatusGroup.PerformLayout();
            this.RecordPanel.ResumeLayout(false);
            this.RecordPanel.PerformLayout();
            this.ExportGroup.ResumeLayout(false);
            this.ExportGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel NavPanel;
        private OxyPlot.WindowsForms.PlotView PlotFigure;
        private Button UpBtn;
        private Button DownBtn;
        private Button MagOnBtn;
        private Button StopBtn;
        private Button StartBtn;
        private ComboBox SensorCombo;
        private Label SensorsLabel;
        private ComboBox COMCombo;
        private Label COMLabel;
        private Button ConnectBtn;
        private NumericUpDown SpeedUpdown;
        private Label SpeedLabel;
        private GroupBox ReportGroup;
        private Button SaveBtn;
        private TextBox MaxForceText;
        private TextBox MaxDecelerationText;
        private Label MaxForceLabel;
        private Label MaxDecelerationLabel;
        private GroupBox SensorParameterGroup;
        private Label BitDepthLabel;
        private Label MeasuringTimesLabel;
        private Label SamplingRateLabel;
        private TextBox BitDepthText;
        private TextBox MeasuringTimesText;
        private TextBox SamplingRateText;
        private GroupBox OtherSpecsGroup;
        private TextBox HumidityText;
        private TextBox TemperatureText;
        private Label HumidityLabel;
        private Label TemperatureLabel;
        private Button DisconnectBtn;
        private PictureBox TopSensorPic;
        private PictureBox BotSensorPic;
        private PictureBox MagnetSensorPic;
        private Label TopSensorLabel;
        private Label BotSensorLabel;
        private Label MagnetSensorLabel;
        private GroupBox SensorsStatusGroup;
        private Button FindBtn;
        private Panel RecordPanel;
        private Panel LogoPanel;
        private PictureBox pictureBox1;
        private Label IUDLABlabel;
        private Label CustomerLabel;
        private GroupBox ExportGroup;
        private Label TestIDLabel;
        private Button NewIDBtn;
        private TextBox TestIDText;
        private TextBox CustomerText;
        private Button MagOffBtn;
    }
}