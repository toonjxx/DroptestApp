using DroptestApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroptestApp
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textfile)
        {
            if (database == true)
            {

            }
            if (textfile == true)
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    } 
}
