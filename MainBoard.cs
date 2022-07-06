using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO.Ports;

using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

using NAudio.Wave;
using DroptestApp.Model;
using DroptestApp.DataAccess;

namespace DroptestApp
{
    public partial class MainBoard : Form
    {
        SerialPort mySerialPort = new SerialPort();

        WaveInEvent wave = new WaveInEvent();
        WaveFileWriter? writer = null;
        readonly string WavePath = Path.Combine(Application.StartupPath, "Temp.wav");
        PlotModel myModel = new PlotModel() { Title = "Deceleration Charts" };
        LineSeries myLineSeries = new LineSeries();
        double itemp = 0;


        public MainBoard()
        {
            InitializeComponent();
        }

        private void MainBoard_Load(object sender, EventArgs e)
        {
            myModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = 900 });
            myModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            PlotFigure.Model = myModel;
            FindBtn_Click(this, e);
        }

        private void MainBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectBtn_Click(this, e);

        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen)
            {
                mySerialPort.Write(new byte[] { 115 }, 0, 1);
                mySerialPort.Close();
            }

            if (wave != null)
            {
                writer?.Dispose();
                writer = null;
                wave.StopRecording();
                wave.Dispose();
            }
            ConnectBtn.Enabled = true;

            StartBtn.Enabled = false;
            StopBtn.Enabled = false;
            MagOnBtn.Enabled = false;
            UpBtn.Enabled = false;
            DownBtn.Enabled = false;
            SpeedUpdown.Enabled = false;
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                mySerialPort.PortName = COMCombo.Text;
                mySerialPort.BaudRate = 115200;
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(OnCOMDataReceivedHandler);
                mySerialPort.Open();
                ConnectBtn.Enabled = false;
                mySerialPort.Write(new byte[] { 105 }, 0, 1);
                mySerialPort.Write(new byte[] { (byte)SpeedUpdown.Value }, 0, 1);

                StartBtn.Enabled = true;
                StopBtn.Enabled = false;
                MagOnBtn.Enabled = true;
                UpBtn.Enabled = true;
                DownBtn.Enabled = true;
                SpeedUpdown.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wrong COM Port or Sensor source");
            }

        }

        private void UpBtn_MouseDown(object sender, MouseEventArgs e)
        {
            mySerialPort.Write(new byte[] { 101 }, 0, 1);
        }

        private void UpBtn_MouseUp(object sender, MouseEventArgs e)
        {
            mySerialPort.Write(new byte[] { 104 }, 0, 1);
        }

        private void DownBtn_MouseDown(object sender, MouseEventArgs e)
        {
            mySerialPort.Write(new byte[] { 102 }, 0, 1);
        }

        private void DownBtn_MouseUp(object sender, MouseEventArgs e)
        {
            mySerialPort.Write(new byte[] { 104 }, 0, 1);
        }

        private void MagOnBtn_Click(object sender, EventArgs e)
        {
            mySerialPort.Write(new byte[] { 103 }, 0, 1);
        }

        private void MagOffBtn_Click(object sender, EventArgs e)
        {
            mySerialPort.Write(new byte[] { 113 }, 0, 1);
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            mySerialPort.Write(new byte[] { 200 }, 0, 1);
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;
            MagOnBtn.Enabled = false;

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            mySerialPort.Write(new byte[] { 201 }, 0, 1);
            StopBtn.Enabled = false;
            StartBtn.Enabled = true;
        }

        private void SpeedUpdown_ValueChanged(object sender, EventArgs e)
        {
            mySerialPort.Write(new byte[] { (byte)SpeedUpdown.Value }, 0, 1);
        }

        private void OnCOMDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            Int32 len = mySerialPort.BytesToRead;
            byte[] COMbuffer = new byte[len];
            mySerialPort.Read(COMbuffer, 0, len);
            try
            {
                SensorStatusUpdate(COMbuffer[len - 1]);
            }
            catch
            {
            }

        }
        private void SensorStatusUpdate(byte data)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<byte>(SensorStatusUpdate), new object[] { data });
                return;
            }
            ///System.Diagnostics.Debug.WriteLine(data);
            switch (data)
            {
                case 1:
                    TopSensorPic.Image = Properties.Resources.circle_gray;
                    BotSensorPic.Image = Properties.Resources.circle_gray;
                    MagnetSensorPic.Image = Properties.Resources.circle_green;
                    break;
                case 10:
                    TopSensorPic.Image = Properties.Resources.circle_gray;
                    BotSensorPic.Image = Properties.Resources.circle_green;
                    MagnetSensorPic.Image = Properties.Resources.circle_gray;
                    break;
                case 11:
                    TopSensorPic.Image = Properties.Resources.circle_gray;
                    BotSensorPic.Image = Properties.Resources.circle_green;
                    MagnetSensorPic.Image = Properties.Resources.circle_green;
                    break;
                case 100:
                    TopSensorPic.Image = Properties.Resources.circle_green;
                    BotSensorPic.Image = Properties.Resources.circle_gray;
                    MagnetSensorPic.Image = Properties.Resources.circle_gray;
                    break;
                case 101:
                    TopSensorPic.Image = Properties.Resources.circle_green;
                    BotSensorPic.Image = Properties.Resources.circle_gray;
                    MagnetSensorPic.Image = Properties.Resources.circle_green;
                    break;
                case 110:
                    TopSensorPic.Image = Properties.Resources.circle_green;
                    BotSensorPic.Image = Properties.Resources.circle_green;
                    MagnetSensorPic.Image = Properties.Resources.circle_gray;
                    break;
                case 111:
                    TopSensorPic.Image = Properties.Resources.circle_green;
                    BotSensorPic.Image = Properties.Resources.circle_green;
                    MagnetSensorPic.Image = Properties.Resources.circle_green;
                    break;
                case 200:
                    System.Diagnostics.Debug.WriteLine("Drop");
                    MaxDecelerationText.Text = "0";
                    itemp = 0;
                    myLineSeries = new LineSeries();
                    myModel.Series.Clear();
                    myModel.Series.Add(myLineSeries);

                    wave = new WaveInEvent();
                    wave.DeviceNumber = SensorCombo.SelectedIndex;
                    wave.WaveFormat = new WaveFormat(int.Parse(SamplingRateText.Text), int.Parse(BitDepthText.Text), 1);
                    writer = new WaveFileWriter(WavePath, wave.WaveFormat);
                    wave.DataAvailable += OnSensorDataAvailable;
                    wave.StartRecording();

                    break;
                default:
                    TopSensorPic.Image = Properties.Resources.circle_gray;
                    BotSensorPic.Image = Properties.Resources.circle_gray;
                    MagnetSensorPic.Image = Properties.Resources.circle_gray;
                    break;
            }

        }

        private void OnSensorDataAvailable(object sender, WaveInEventArgs args)
        {
            byte[] signal = args.Buffer;
            if (writer != null)
            {
                writer.Write(args.Buffer, 0, args.BytesRecorded);
                writer.Flush();
                if (writer.Position > wave.WaveFormat.AverageBytesPerSecond * int.Parse(MeasuringTimesText.Text))
                {
                    writer?.Dispose();
                    writer = null;
                    wave.StopRecording();
                    wave.Dispose();
                    Results_Update(myLineSeries.MaxY.ToString("F3"));
                }
            }
            for (int i = 0; i < signal.Length / 2; i++)
            {
                short values = BitConverter.ToInt16(signal, i * 2);
                myLineSeries.Points.Add(new DataPoint(itemp += 0.01, values));
            }
            myModel.InvalidatePlot(true);

        }



        private void FindBtn_Click(object sender, EventArgs e)
        {
            COMCombo.Items.Clear();
            SensorCombo.Items.Clear();

            string[] ports = SerialPort.GetPortNames();
            COMCombo.Items.AddRange(ports);
            COMCombo.SelectedIndex = 0;

            for (int n = 0; n < WaveIn.DeviceCount; n++)
            {
                var caps = WaveIn.GetCapabilities(n);
                SensorCombo.Items.Add(caps.ProductName);
            }
            SensorCombo.SelectedIndex = 0;
        }

        private void Results_Update(string data)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Results_Update), new object[] { data });
                return;
            }
            MaxDecelerationText.Text = data;
        }

        // Generates a random string with a given size.    
        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);
            Random random = new Random();
            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char) random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        private void NewIDBtn_Click(object sender, EventArgs e)
        {
            TestIDText.Text = RandomString(8);
        }


        private bool ValidateParam()
        {
            bool output = true;

            int SamplingRate = 0;
            bool SamplingRateValid = int.TryParse(SamplingRateText.Text,out SamplingRate);
            if (SamplingRateValid == false)
            {
                output = false;
            }
            if (SamplingRate < 1 || SamplingRate > 64000)
            {
                output = false;
            }

            int MeasuringTimes = 0;
            bool MeasuringTimesValid = int.TryParse(MeasuringTimesText.Text, out MeasuringTimes);
            if (MeasuringTimesValid == false)
            {
                output = false;
            }
            if (MeasuringTimes < 1)
            {
                output = false;
            }

            int BitDepth = 0;
            bool BitDepthValid = int.TryParse(BitDepthText.Text, out BitDepth);
            if (BitDepthValid == false)
            {
                output = false;
            }
            if (BitDepth%8!=0)
            {
                output = false;
            }

            return output;
        }


        private bool ValidateExportInfo()
        {   

            bool output = true;

            float Temperature = 0;
            bool TemperatureValid = float.TryParse (TemperatureText.Text,out Temperature);
            if (TemperatureValid == false)
            {
                output=false;
            }

            float Humidity = 0;
            bool HumidityValid = float.TryParse(HumidityText.Text, out Humidity);
            if (HumidityValid == false)
            {
                output = false;
            }
            if (Humidity<0||Humidity>100)
            {
                output |= false;
            }

            if (String.IsNullOrEmpty(CustomerText.Text))
            {
                output = false;
            }

            double MaxForce = 0;
            double.TryParse(MaxForceText.Text,out MaxForce);

            double MaxDeceleration = 0;
            double.TryParse ((MaxDecelerationText.Text),out MaxDeceleration);

            if(MaxForce == 0 && MaxDeceleration == 0)
            {
                output = false;
            }



            return output;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateParam()&&ValidateExportInfo())
            {
                DateTime TimeNow = DateTime.Now;
                string RecordTime = TimeNow.ToString("h:mm tt MM/dd/yyyy");
                TestModel model = new TestModel(
                    CustomerText.Text,
                    TestIDText.Text,
                    MaxDecelerationText.Text,
                    MaxForceText.Text,
                    RecordTime,
                    TemperatureText.Text,
                    HumidityText.Text,
                    SamplingRateText.Text,
                    BitDepthText.Text,
                    MeasuringTimesText.Text);
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateTest(model);
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
