using DroptestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroptestApp.DataAccess.TextConnector
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return Path.Combine(Application.StartupPath, fileName);
        }

        public static List<string>  LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<TestModel> ConvertToTestModel(this List<string> lines)
        {
            List<TestModel> output = new List<TestModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TestModel p = new TestModel();
                p.TestID = cols[0];
                p.CustomerName = cols[1];
                p.RecordTime = cols[2];
                p.MaxForce = double.Parse(cols[3]);
                p.MaxDeceleration = double.Parse(cols[4]);
                p.Temperature = float.Parse(cols[5]);
                p.Humidity = float.Parse(cols[6]);
                p.SamplingRate = int.Parse(cols[7]);
                p.MeasuringTime = int.Parse(cols[8]);
                p.BitDepth = int.Parse(cols[9]);
                output.Add(p);
            }
            return output;
        }

        public static void SaveToTestFile(this List<TestModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (TestModel p in models)
            {
                lines.Add($"{p.TestID},{p.CustomerName},{p.RecordTime},{p.MaxForce},{p.MaxDeceleration},{p.Temperature},{p.Humidity},{p.SamplingRate},{p.MeasuringTime},{p.BitDepth}");
            }
            File.WriteAllLines(fileName.FullFilePath(),lines);
        }
    }
}
