using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Capstone.Web.Models;
using System.Data.SqlClient;

namespace Capstone.Web.DAL
{
    public class UserSqlDAL : IUserDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["potholeDB"].ConnectionString;

        public bool RegisterUser(RegisterModel newUser)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand regUser = new SqlCommand($"INSERT INTO appUser(email, password, name, userType, salt) VALUES(@email, @password, @name, @userType, @salt);", conn);

                    regUser.Parameters.AddWithValue("@email", newUser.Email);
                    regUser.Parameters.AddWithValue("@password", newUser.Password);
                    regUser.Parameters.AddWithValue("@name", newUser.Name);
                    regUser.Parameters.AddWithValue("@userType", newUser.UserType);
                    regUser.Parameters.AddWithValue("@salt", newUser.Salt);

                    int result = regUser.ExecuteNonQuery();

                    if(result > 0)
                    {
                        return true;
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }




            return false;
        }
    }
}