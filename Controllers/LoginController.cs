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
        public int Register(string userName, string password, string name, string email, string address)
        {
            int returnCase = usersController.Create(userName, password, name, email, address);
            //Checks for the returned error code value(if 0 then no error)
            return returnCase;
        }

    }
}
