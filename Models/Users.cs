using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndOfSemester3.Models
{
	public class Users
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public decimal Rating { get; set; }
		public int NumberOfSales { get; set; }
		public bool IsAdmin { get; set; }
		public string Salt { get; set; }

		public Users()
        {
        }
		public Users(string username, string password, string name, string email, string address, decimal rating, int numberOfSales, bool isAdmin, string salt)
		{
			this.Username = username;
			this.Password = password;
			this.Name = name;
			this.Email = email;
			this.Address = address;
			this.Rating = rating;
			this.NumberOfSales = numberOfSales;
			this.IsAdmin = isAdmin;
			this.Salt = salt;
		}
	}
}