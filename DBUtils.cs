﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pr6
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "192.168.70.5";
            int port = 3306;
            string database = "KnockOut";
            string username = "appuser";
            string password = "pass";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
