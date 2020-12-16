using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndOfSemester3.Models
{
    public class IsLoggedIn
    {
        public string UserName { get; set; }
        private static IsLoggedIn _instance;
        //Here we are using a singleton pattern
        private IsLoggedIn()
        {

        }

        public static IsLoggedIn GetInstance()
        {
            if (_instance == null)
            {
                _instance = new IsLoggedIn();
            }
            return _instance;
        }
    }
}