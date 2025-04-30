using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace loaf_and_latte_system.Config
{
    public class DatabaseConnection
    {
        private static MySqlConnection _instance;
        private static readonly object _lock = new object();

        // Connection details
        private static readonly string server = "localhost";
        private static readonly string database = "lal_db";
        private static readonly string userId = "sokny";
        private static readonly string password = "1234@@";
        private static readonly int port = 3306;

        private DatabaseConnection() { }

        public static MySqlConnection GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        string connStr = $"Server={server};Port={port};Database={database};User Id={userId};Password={password};";
                        _instance = new MySqlConnection(connStr);
                    }
                }
            }
            return _instance;
        }
    }

}
