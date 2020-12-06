using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndOfSemester3.Models
{
    public class IsLoggedIn
    {
        public string userName { get; set; }
        private static IsLoggedIn instance;
        //Here we are using a singleton pattern
        private IsLoggedIn()
        {

        }

        public static IsLoggedIn getInstance()
        {
            if (instance == null)
            {
                instance = new IsLoggedIn();
            }
            return instance;
        }
    }
}