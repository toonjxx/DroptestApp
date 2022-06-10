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
            this.MagnetBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SensorCombo = new System.Windows.Forms.ComboBox();
            this.SensorsLabel = new System.Windows.Forms.Label();
            this.COMCombo = new System.Windows.Forms.ComboBox();
            this.COMLabel = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.SpeedUpdown = new System.Windows.Forms.NumericUpDown();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.ConfigBtn = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.ReportGroup = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.MaxForceText = new System.Windows.Forms.TextBox();
            this.MaxDecelerationText = new System.Windows.Forms.TextBox();
            this.MaxForceLabel = new System.Windows.Forms.Label();
            this.MaxDecelerationLabel = new System.Windows.Forms.Label();
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
            this.StopRecordBtn = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.Silver;
            this.NavPanel.Controls.Add(this.StopRecordBtn);
            this.NavPanel.Controls.Add(this.LogoPanel);
            this.NavPanel.Controls.Add(this.ConfigBtn);
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(222, 720);
            this.NavPanel.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.DimGray;
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Controls.Add(this.IUDLABlabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(222, 90);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DroptestApp.Properties.Resources.icons8_redux_50;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // IUDLABlabel
            // 
            this.IUDLABlabel.AutoSize = true;
            this.IUDLABlabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IUDLABlabel.ForeColor = System.Drawing.Color.White;
            this.IUDLABlabel.Location = new System.Drawing.Point(91, 26);
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
            this.PlotFigure.Location = new System.Drawing.Point(228, 189);
            this.PlotFigure.Name = "PlotFigure";
            this.PlotFigure.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlotFigure.Size = new System.Drawing.Size(846, 366);
            this.PlotFigure.TabIndex = 1;
            this.PlotFigure.Text = "PlotFigure";
            this.PlotFigure.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PlotFigure.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PlotFigure.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // UpBtn
            // 
            this.UpBtn.Image = global::DroptestApp.Properties.Resources.caret_arrow_up;
            this.UpBtn.Location = new System.Drawing.Point(714, 36);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(50, 50);
            this.UpBtn.TabIndex = 2;
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBtn_MouseDown);
            this.UpBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpBtn_MouseUp);
            // 
            // DownBtn
            // 
            this.DownBtn.Image = global::DroptestApp.Properties.Resources.sort_down;
            this.DownBtn.Location = new System.Drawing.Point(714, 115);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(50, 50);
            this.DownBtn.TabIndex = 3;
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownBtn_MouseDown);
            this.DownBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DownBtn_MouseUp);
            // 
            // MagnetBtn
            // 
            this.MagnetBtn.Location = new System.Drawing.Point(593, 137);
            this.MagnetBtn.Name = "MagnetBtn";
            this.MagnetBtn.Size = new System.Drawing.Size(92, 28);
            this.MagnetBtn.TabIndex = 4;
            this.MagnetBtn.Text = "Magnet";
            this.MagnetBtn.UseVisualStyleBackColor = true;
            this.MagnetBtn.Click += new System.EventHandler(this.MagnetBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(593, 103);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(92, 28);
            this.StopBtn.TabIndex = 5;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(593, 69);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(92, 28);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // SensorCombo
            // 
            this.SensorCombo.FormattingEnabled = true;
            this.SensorCombo.Location = new System.Drawing.Point(296, 36);
            this.SensorCombo.Name = "SensorCombo";
            this.SensorCombo.Size = new System.Drawing.Size(186, 28);
            this.SensorCombo.TabIndex = 7;
            // 
            // SensorsLabel
            // 
            this.SensorsLabel.AutoSize = true;
            this.SensorsLabel.Location = new System.Drawing.Point(228, 39);
            this.SensorsLabel.Name = "SensorsLabel";
            this.SensorsLabel.Size = new System.Drawing.Size(62, 20);
            this.SensorsLabel.TabIndex = 8;
            this.SensorsLabel.Text = "Sensors:";
            // 
            // COMCombo
            // 
            this.COMCombo.FormattingEnabled = true;
            this.COMCombo.Location = new System.Drawing.Point(296, 88);
            this.COMCombo.Name = "COMCombo";
            this.COMCombo.Size = new System.Drawing.Size(186, 28);
            this.COMCombo.TabIndex = 9;
            // 
            // COMLabel
            // 
            this.COMLabel.AutoSize = true;
            this.COMLabel.Location = new System.Drawing.Point(228, 91);
            this.COMLabel.Name = "COMLabel";
            this.COMLabel.Size = new System.Drawing.Size(49, 20);
            this.COMLabel.TabIndex = 10;
            this.COMLabel.Text = "COM: ";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(392, 137);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(90, 28);
            this.ConnectBtn.TabIndex = 11;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // SpeedUpdown
            // 
            this.SpeedUpdown.Location = new System.Drawing.Point(593, 36);
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
            this.SpeedLabel.Location = new System.Drawing.Point(507, 39);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(80, 20);
            this.SpeedLabel.TabIndex = 13;
            this.SpeedLabel.Text = "Speed (%):";
            // 
            // ConfigBtn
            // 
            this.ConfigBtn.Location = new System.Drawing.Point(50, 133);
            this.ConfigBtn.Name = "ConfigBtn";
            this.ConfigBtn.Size = new System.Drawing.Size(90, 28);
            this.ConfigBtn.TabIndex = 14;
            this.ConfigBtn.Text = "Config";
            this.ConfigBtn.UseVisualStyleBackColor = true;
            this.ConfigBtn.Click += new System.EventHandler(this.ConfigBtn_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(865, 138);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(191, 29);
            this.ProgressBar.TabIndex = 16;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(787, 141);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(72, 20);
            this.ProgressLabel.TabIndex = 17;
            this.ProgressLabel.Text = "Progress: ";
            // 
            // ReportGroup
            // 
            this.ReportGroup.Controls.Add(this.SaveBtn);
            this.ReportGroup.Controls.Add(this.MaxForceText);
            this.ReportGroup.Controls.Add(this.MaxDecelerationText);
            this.ReportGroup.Controls.Add(this.MaxForceLabel);
            this.ReportGroup.Controls.Add(this.MaxDecelerationLabel);
            this.ReportGroup.Location = new System.Drawing.Point(787, 570);
            this.ReportGroup.Name = "ReportGroup";
            this.ReportGroup.Size = new System.Drawing.Size(269, 128);
            this.ReportGroup.TabIndex = 18;
            this.ReportGroup.TabStop = false;
            this.ReportGroup.Text = "Report";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(168, 89);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(95, 29);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // MaxForceText
            // 
            this.MaxForceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxForceText.Location = new System.Drawing.Point(168, 59);
            this.MaxForceText.Name = "MaxForceText";
            this.MaxForceText.Size = new System.Drawing.Size(95, 27);
            this.MaxForceText.TabIndex = 3;
            this.MaxForceText.Text = "0";
            // 
            // MaxDecelerationText
            // 
            this.MaxDecelerationText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxDecelerationText.Location = new System.Drawing.Point(168, 25);
            this.MaxDecelerationText.Name = "MaxDecelerationText";
            this.MaxDecelerationText.Size = new System.Drawing.Size(95, 27);
            this.MaxDecelerationText.TabIndex = 2;
            this.MaxDecelerationText.Text = "0";
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
            // SensorParameterGroup
            // 
            this.SensorParameterGroup.Controls.Add(this.BitDepthText);
            this.SensorParameterGroup.Controls.Add(this.MeasuringTimesText);
            this.SensorParameterGroup.Controls.Add(this.SamplingRateText);
            this.SensorParameterGroup.Controls.Add(this.BitDepthLabel);
            this.SensorParameterGroup.Controls.Add(this.MeasuringTimesLabel);
            this.SensorParameterGroup.Controls.Add(this.SamplingRateLabel);
            this.SensorParameterGroup.Location = new System.Drawing.Point(244, 570);
            this.SensorParameterGroup.Name = "SensorParameterGroup";
            this.SensorParameterGroup.Size = new System.Drawing.Size(263, 128);
            this.SensorParameterGroup.TabIndex = 19;
            this.SensorParameterGroup.TabStop = false;
            this.SensorParameterGroup.Text = "Sensor Parameters";
            // 
            // BitDepthText
            // 
            this.BitDepthText.Location = new System.Drawing.Point(157, 91);
            this.BitDepthText.Name = "BitDepthText";
            this.BitDepthText.Size = new System.Drawing.Size(100, 27);
            this.BitDepthText.TabIndex = 5;
            this.BitDepthText.Text = "16";
            // 
            // MeasuringTimesText
            // 
            this.MeasuringTimesText.Location = new System.Drawing.Point(157, 56);
            this.MeasuringTimesText.Name = "MeasuringTimesText";
            this.MeasuringTimesText.Size = new System.Drawing.Size(100, 27);
            this.MeasuringTimesText.TabIndex = 4;
            this.MeasuringTimesText.Text = "5";
            // 
            // SamplingRateText
            // 
            this.SamplingRateText.Location = new System.Drawing.Point(157, 22);
            this.SamplingRateText.Name = "SamplingRateText";
            this.SamplingRateText.Size = new System.Drawing.Size(100, 27);
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
            this.OtherSpecsGroup.Location = new System.Drawing.Point(513, 570);
            this.OtherSpecsGroup.Name = "OtherSpecsGroup";
            this.OtherSpecsGroup.Size = new System.Drawing.Size(268, 128);
            this.OtherSpecsGroup.TabIndex = 20;
            this.OtherSpecsGroup.TabStop = false;
            this.OtherSpecsGroup.Text = "Other Specs";
            // 
            // HumidityText
            // 
            this.HumidityText.Location = new System.Drawing.Point(131, 56);
            this.HumidityText.Name = "HumidityText";
            this.HumidityText.Size = new System.Drawing.Size(131, 27);
            this.HumidityText.TabIndex = 5;
            this.HumidityText.Text = "0";
            // 
            // TemperatureText
            // 
            this.TemperatureText.Location = new System.Drawing.Point(131, 22);
            this.TemperatureText.Name = "TemperatureText";
            this.TemperatureText.Size = new System.Drawing.Size(131, 27);
            this.TemperatureText.TabIndex = 4;
            this.TemperatureText.Text = "0";
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
            this.DisconnectBtn.Location = new System.Drawing.Point(488, 137);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(90, 28);
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
            this.SensorsStatusGroup.Location = new System.Drawing.Point(787, 24);
            this.SensorsStatusGroup.Name = "SensorsStatusGroup";
            this.SensorsStatusGroup.Size = new System.Drawing.Size(269, 108);
            this.SensorsStatusGroup.TabIndex = 15;
            this.SensorsStatusGroup.TabStop = false;
            this.SensorsStatusGroup.Text = "Sensors Status";
            // 
            // StopRecordBtn
            // 
            this.StopRecordBtn.Location = new System.Drawing.Point(91, 189);
            this.StopRecordBtn.Name = "StopRecordBtn";
            this.StopRecordBtn.Size = new System.Drawing.Size(94, 29);
            this.StopRecordBtn.TabIndex = 22;
            this.StopRecordBtn.Text = "Stop Record";
            this.StopRecordBtn.UseVisualStyleBackColor = true;
            this.StopRecordBtn.Click += new System.EventHandler(this.StopRecordBtn_Click);
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.OtherSpecsGroup);
            this.Controls.Add(this.SensorParameterGroup);
            this.Controls.Add(this.ReportGroup);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.SensorsStatusGroup);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.SpeedUpdown);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.COMLabel);
            this.Controls.Add(this.COMCombo);
            this.Controls.Add(this.SensorsLabel);
            this.Controls.Add(this.SensorCombo);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.MagnetBtn);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.PlotFigure);
            this.Controls.Add(this.NavPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainBoard";
            this.Text = "MainBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainBoard_FormClosing);
            this.Load += new System.EventHandler(this.MainBoard_Load);
            this.NavPanel.ResumeLayout(false);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel NavPanel;
        private Panel LogoPanel;
        private PictureBox pictureBox1;
        private Label IUDLABlabel;
        private OxyPlot.WindowsForms.PlotView PlotFigure;
        private Button UpBtn;
        private Button DownBtn;
        private Button MagnetBtn;
        private Button StopBtn;
        private Button StartBtn;
        private ComboBox SensorCombo;
        private Label SensorsLabel;
        private ComboBox COMCombo;
        private Label COMLabel;
        private Button ConnectBtn;
        private NumericUpDown SpeedUpdown;
        private Label SpeedLabel;
        private Button ConfigBtn;
        private ProgressBar ProgressBar;
        private Label ProgressLabel;
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
        private Button StopRecordBtn;
    }
}