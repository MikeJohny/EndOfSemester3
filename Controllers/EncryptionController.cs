using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EndOfSemester3.Controllers
{
    public class EncryptionController : ApiController
    {
        //Encrypt
        public string EncryptPassword(string password)
        {
            string passPhrase = ConfigurationManager.AppSettings["encryptionPassPhrase"];

            return Encrypt.EncryptString(password, passPhrase);
        }
        //Decrypt
        public string DecryptPassword(string password)
        {
            string passPhrase = ConfigurationManager.AppSettings["encryptionPassPhrase"];

            return Encrypt.DecryptString(password, passPhrase);
        }
    }
}
