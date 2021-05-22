using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsForDataBase_URBAEV
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "p_orders";
            string username = "root";
            string password = "1234";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
