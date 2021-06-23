using log4net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDBConnection
{
    class ResultPrinter
    {
        private static readonly ILog logger = Log4Net.GetInstance();
        internal static void Print(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                string outputString = "";
                for (int f = 0; f < reader.FieldCount; f++)
                {
                    outputString = outputString + reader[f] + " ";
                }
                logger.Info(outputString);
            }
            reader.Close();
        }

        internal static void PrintList(List<Tests> listTests)
        {
            foreach(Tests test in listTests)
            {
                logger.Info($"{test.p}, {test.t}, {test.val}");
            }
        }
    }
}
