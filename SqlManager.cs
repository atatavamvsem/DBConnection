using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConsoleDBConnection
{
    class SqlManager
    {
        static MySqlCommand command;
        static MySqlConnection conn;
        static readonly string connStr = "server=" + Properties.ConfData.Server +
                            ";user=" + Properties.ConfData.User +
                            ";database=" + Properties.ConfData.DB +
                            ";password=" + Properties.ConfData.Password + ";";
        public static void CreateConn() 
        { 
            conn = new MySqlConnection(connStr);
            conn.Open();
        }

        public static MySqlDataReader ExecuteQuery(string query)
        {
            command = new MySqlCommand(query, conn);
            return command.ExecuteReader();
        }

        public static void CloseConn()
        {
            conn.Close();
        }
    }
}
