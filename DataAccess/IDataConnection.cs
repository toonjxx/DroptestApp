using DroptestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroptestApp.DataAccess
{
    public interface IDataConnection
    {
        TestModel CreateTest(TestModel model);

    }
}
