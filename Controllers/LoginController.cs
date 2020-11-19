using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EndOfSemester3.Controllers
{
    public class LoginController : ApiController
    {
        UsersController usersController = new UsersController();
        EncryptionController encryptionController = new EncryptionController();

        // Login
        public bool Login(string userName, string password)
        {
            bool isLoggedIn = false;
            var users = usersController.Get();
            for (int i = 0; i < users.Count(); i++)
            {
                if (users.ElementAt(i).username == userName)
                {
                    password += users.ElementAt(i).SALT;
                    if (encryptionController.EncryptPassword(password) == users.ElementAt(i).password)
                    {
                        isLoggedIn = true;
                    }
                }
            }
            return isLoggedIn;
        }

        // Register
        public void Register(string userName, string password, string name, string email, string address)
        {
            string sql = "INSERT INTO Users (username, password, name, email, address, rating, numberOfSales, isAdmin, SALT)" +
                " VALUES (@username, @password, @name, @email, @address, @rating, @numberOfSales, @isAdmin, @SALT)";

            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            string salt = Guid.NewGuid().ToString("N").Substring(0, 20);
            string hashedPassword = encryptionController.EncryptPassword(password + salt);
            using (var connection = new SqlConnection(connStr))
            {
                var product = connection.Query(sql, new {
                    username = userName, 
                    password = hashedPassword,
                    name = name, 
                    email = email, 
                    address = address,
                    rating = 0,
                    numberOfSales = 0, 
                    isAdmin = 0,
                    SALT = salt 
                });
                
            }
        }

    }
}
