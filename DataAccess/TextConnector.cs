using DroptestApp.DataAccess;
using DroptestApp.DataAccess.TextConnector;
using DroptestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroptestApp
{
    public class TextConnector : IDataConnection
    {
        private const string TestFile = "TestReport.csv";
        public TestModel CreateTest(TestModel model)
        {
            List<TestModel> test = TestFile.FullFilePath().LoadFile().ConvertToTestModel();
            test.Add(model);
            test.SaveToTestFile(TestFile);
            return model;
        }
    }
}
