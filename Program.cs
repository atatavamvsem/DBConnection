using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using MySql.Data.MySqlClient;

namespace ConsoleDBConnection
{
    class Program
    {
        private static readonly ILog logger = Log4Net.GetInstance();
        static void Main(string[] args)
        {
            SqlManager.CreateConn();

            logger.Info("Result Sql query 'Min Worker Test Time'\n[PROJECT] [TEST] [MIN_WORK_TIME]");
            ResultPrinter.Print(SqlManager.ExecuteQuery(Properties.SqlQuery.MinTimeTestWorkQuery));

            logger.Info("Result Sql query 'Count Unique Tests'\n[PROJECT] [TEST_COUNT]");
            ResultPrinter.Print(SqlManager.ExecuteQuery(Properties.SqlQuery.CountUniqueTests));
            
            logger.Info("Result Sql query 'Tests running after 2021-11-7'\n[PROJECT] [TEST] [DATE]");
            ResultPrinter.Print(SqlManager.ExecuteQuery(Properties.SqlQuery.TestsAfterDate));

            logger.Info("Result Sql query 'Tests running on browser'\n[BROWSER] [TEST_COUNT]");
            ResultPrinter.Print(SqlManager.ExecuteQuery(Properties.SqlQuery.TestsRunningOnBrowser));

            SqlManager.CloseConn();
        }
    }
}
