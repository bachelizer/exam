using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Http;
using crud_app_backend.Model;
using crud_app_backend.Contracts;

namespace scholarship_backend.Repository
{
    public class ReportRepo : IReport
    {
        private string connectionString;

        public ReportRepo()
        {
            connectionString = ConnectionStr.databaseConnection;
        }
        public IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(connectionString);
            }
        }
        public async Task<IEnumerable<Report>> Read()
        {
            // add your code here
            // Select only active user (base on UserStatus column)
            // for dashboard widget
            string qry ="";
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var data = await dbConnection.QueryAsync<Report>(qry);
                return data;
            }
        }
    }
}