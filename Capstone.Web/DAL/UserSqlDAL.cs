using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Capstone.Web.Models;

namespace Capstone.Web.DAL
{
    public class UserSqlDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["potholeDB"].ConnectionString;

        public void RegisterUser(RegisterModel newUser)
        {

        }
    }
}