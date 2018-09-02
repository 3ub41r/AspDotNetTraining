using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspDotNetTraining.Services
{
    public static class ConnectionFactory
    {
        public static IDbConnection GetConnection(string connectionKey = "Database")
        {
            var connectionString = ConfigurationManager.ConnectionStrings[connectionKey].ToString();
            return new SqlConnection(connectionString);
        }
    }
}