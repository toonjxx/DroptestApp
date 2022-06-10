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

namespace DroptestApp
{
    public partial class MainBoard : Form
    {
        SerialPort mySerialPort = new SerialPort();

        WaveIn wave;
        WaveFileWriter? writer=null;
        string WavePath = Path.Combine(Application.StartupPath,"/Temp.wav");
        PlotModel myModel = new PlotModel() { Title = "Deceleration Charts"};
        LineSeries myLineSeries;
        double itemp = 0;

        public MainBoard()
        {
            InitializeComponent();
        }

        private void MainBoard_Load(object sender, EventArgs e)
        {
            myModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom,Minimum=0,Maximum=900});
            myModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left});
            PlotFigure.Model = myModel;

            string[] ports = SerialPort.GetPortNames();
            COMCombo.Items.AddRange(ports);
            COMCombo.SelectedIndex = 0;

            for (int n = -1; n < WaveIn.DeviceCount; n++)
            {
                var caps = WaveIn.GetCapabilities(n);
                SensorCombo.Items.Add(caps.ProductName);
            }
            SensorCombo.SelectedIndex = 0;
        }

        private void MainBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mySerialPort.IsOpen)
                mySerialPort.Write(new byte[] { 115 }, 0, 1);
                mySerialPort.Close();
                writer?.Dispose();
                writer = null;
                wave.StopRecording();
                wave.Dispose();
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen)
            {
                mySerialPort.Write(new byte[] { 115 }, 0, 1);
                mySerialPort.Close();
                ConnectBtn.Enabled = true;
            }

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
                mySerialPort.Write(new byte[] { (byte)SpeedUpdown.Value },0,1);

                wave = new WaveIn();
                wave.DeviceNumber = 1;
                System.Diagnostics.Debug.WriteLine(SensorCombo.SelectedItem);
                wave.WaveFormat = new WaveFormat(int.Parse(SamplingRateText.Text), int.Parse(BitDepthText.Text), 2);
                writer = new WaveFileWriter(WavePath, wave.WaveFormat);
                wave.DataAvailable += OnSensorDataAvailable;
            }
            catch(Exception ex)
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

        private void MagnetBtn_Click(object sender, EventArgs e)
        {   
            mySerialPort.Write(new byte[] { 103 }, 0, 1);
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            mySerialPort.Write(new byte[] { 200 }, 0, 1);
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            mySerialPort.Write(new byte[] { 201 }, 0, 1);
        }

        private void SpeedUpdown_ValueChanged(object sender, EventArgs e)
        {
            mySerialPort.Write(new byte[] { (byte)SpeedUpdown.Value }, 0, 1);
        }

        private void OnCOMDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            Int32 len = mySerialPort.BytesToRead;
            byte[] COMbuffer = new byte[len];
            mySerialPort.Read(COMbuffer,0,len);
            System.Diagnostics.Debug.WriteLine(COMbuffer[0]);
            SensorStatusUpdate(COMbuffer[len - 1]);
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
                    itemp = 0;
                    myLineSeries = new LineSeries();
                    myModel.Series.Add(myLineSeries);
                    wave.StartRecording();
                    break;
                default:
                    TopSensorPic.Image = Properties.Resources.circle_gray;
                    BotSensorPic.Image = Properties.Resources.circle_gray;
                    MagnetSensorPic.Image = Properties.Resources.circle_gray;
                    break;
            }

        }


        private void ConfigBtn_Click(object sender, EventArgs e)
        {
        }

        private void OnSensorDataAvailable(object sender, WaveInEventArgs args)
        {
            byte[] signal = args.Buffer;
            if (writer!=null)
            {
                writer.Write(args.Buffer, 0, args.BytesRecorded);
                writer.Flush();
                if (writer.Position > wave.WaveFormat.AverageBytesPerSecond * int.Parse(MeasuringTimesText.Text))
                {
                    writer?.Dispose();
                    writer = null;
                    wave.StopRecording();
                    wave.Dispose();
                }
            }

            for (int i=0;i< signal.Length/2;i++)
            {
                short values = BitConverter.ToInt16(signal, i*2);
                myLineSeries.Points.Add(new DataPoint(itemp += 0.01, values));
            }
            myModel.InvalidatePlot(true);
        }

        private void StopRecordBtn_Click(object sender, EventArgs e)      
        {
        }
    }
}
