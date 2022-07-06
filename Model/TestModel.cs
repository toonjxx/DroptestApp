using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroptestApp.Model
{
    public class TestModel
    {
        public string CustomerName { get; set; }
        public string TestID { get; set; }
        public double MaxDeceleration { get; set; }
        public double MaxForce { get; set; }
        public string RecordTime { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public int SamplingRate { get; set; }
        public int BitDepth { get; set; }
        public int MeasuringTime { get; set; }

        public TestModel(string customerName, string testID, string maxDeceleration, string maxForce, string recordTime, string temperature, string humidity, string samplingRate, string bitDepth, string measuringTime)
        {
            CustomerName = customerName;
            TestID = testID;

            double MaxDecelerationValue = 0;
            double.TryParse(maxDeceleration, out MaxDecelerationValue);
            MaxDeceleration = MaxDecelerationValue;

            double MaxForceValue = 0;
            double.TryParse(maxForce, out MaxForceValue);
            MaxForce = MaxForceValue;

            RecordTime = recordTime;

            float TemperatureValue = 0;
            float.TryParse(temperature,out TemperatureValue);
            Temperature = TemperatureValue;

            float HumidityValue = 0;
            float.TryParse(humidity,out HumidityValue);
            Humidity = HumidityValue;

            int SamplingRateValue = 0;
            int.TryParse(samplingRate, out SamplingRateValue);
            SamplingRate = SamplingRateValue;

            int BitDepthValue = 0;
            int.TryParse(bitDepth,out BitDepthValue);
            BitDepth = BitDepthValue;

            int MeasuringTimeValue = 0;
            int.TryParse(measuringTime,out MeasuringTimeValue);
            MeasuringTime = MeasuringTimeValue;

        }
        public TestModel()
        {

        }
    }
}
