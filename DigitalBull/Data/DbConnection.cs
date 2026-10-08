using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBull.Data
{
    public class DbConnection
    {
        private readonly string _connectionString;

        public DbConnection()
        {
            _connectionString = "Data Source=DIEGOCHACON\\SQLDEVELOPER;Initial Catalog=db_digitalbull ;User=sa; Password=diego1999; TrustServerCertificate=true";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

    }
}
