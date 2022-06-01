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
    public class CRUDRepo : ICRUD
    {
        private string connectionString;
        // private readonly StudentRepo _studentRepo;

        public CRUDRepo()
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

        public async Task<IEnumerable<Instructor>> Read()
        {
            // add your code here ***Fetching Instructors***
            string qry = "";
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var data = await dbConnection.QueryAsync<Instructor>(qry);
                return data;
            }
        }

        public async Task Create(Instructor data)
        {
            string qry = @"insert into tbl_instructor(designation, UserStatus, first_name, middle_name, last_name, institute_id) values(@designation, @UserStatus, @first_name, @middle_name, @last_name, @institute_id)";
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var transaction = dbConnection.BeginTransaction();
                try
                {
                    await dbConnection.ExecuteAsync(qry, data);
                    transaction.Commit();
                }
                catch(Exception ex)
                 {
                     transaction.Rollback();
                 }
                
            }
        }
        public async Task Update(Instructor data)
        {
            string qry = @"update tbl_instructor set designation = @designation, UserStatus = @UserStatus, first_name = @first_name, middle_name = @middle_name, last_name = @last_name, institute_id = @institute_id where instructor_id = @instructor_id;";
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var transaction = dbConnection.BeginTransaction();
                try
                {
                    await dbConnection.ExecuteAsync(qry, data);
                    transaction.Commit();
                }
                catch(Exception ex)
                 {
                     transaction.Rollback();
                 }
                
            }
        }

        public async Task Delete(int instuctor_id)
        {
            string qry = @"delete from tbl_instructor where instructor_id = @instuctor_id;";
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var transaction = dbConnection.BeginTransaction();
                try
                {
                    await dbConnection.ExecuteAsync(qry, new { instuctor_id = instuctor_id} );
                    transaction.Commit();
                }
                catch(Exception ex)
                 {
                     transaction.Rollback();
                 }
                
            }
        }
    }
}