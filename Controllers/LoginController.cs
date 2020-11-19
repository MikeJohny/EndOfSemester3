using System;
using System.Collections.Generic;
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
        // GET: api/Login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public bool Get(string userName, string password)
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

        // POST: api/Login
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
