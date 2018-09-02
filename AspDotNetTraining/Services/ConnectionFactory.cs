using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspDotNetTraining.Services
{
    public class ConnectionFactory
    {
        private readonly string _connectionString;
        
        public ConnectionFactory(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public ConnectionFactory()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}