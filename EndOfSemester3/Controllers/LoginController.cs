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
        UsersController _usersController = new UsersController();
        EncryptionController _encryptionController = new EncryptionController();

        // Login
        public bool Login(string userName, string password)
        {
            bool isLoggedIn = false;
            var users = _usersController.Get();
            for (int i = 0; i < users.Count(); i++)
            {
                if (users.ElementAt(i).Username == userName)
                {
                    password += users.ElementAt(i).Salt;
                    if (_encryptionController.EncryptPassword(password) == users.ElementAt(i).Password)
                    {
                        Models.IsLoggedIn.GetInstance().UserName = userName;
                        isLoggedIn = true;
                    }
                }
            }
            return isLoggedIn;
        }

        // Register
        public int Register(string userName, string password, string name, string email, string address)
        {
            int returnCase = _usersController.Create(userName, password, name, email, address);
            if (returnCase == 0)
            {
                Models.IsLoggedIn.GetInstance().UserName = userName;
            }
            //Returns error code value(if 0 then no error)
            return returnCase;
        }

    }
}
