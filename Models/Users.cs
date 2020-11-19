using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndOfSemester3.Models
{
	public class Users
	{
		public int id { get; set; }
		public string username { get; set; }
		public string password { get; set; }
		public string name { get; set; }
		public string email { get; set; }
		public string address { get; set; }
		public decimal rating { get; set; }
		public int numberOfSales { get; set; }
		public bool isAdmin { get; set; }
		public string SALT { get; set; }

		public Users(int id_, string username_, string password_, string name_, string email_, string address_, decimal rating_, int numberOfSales_, bool isAdmin_, string SALT_)
		{
			this.id = id_;
			this.username = username_;
			this.password = password_;
			this.name = name_;
			this.email = email_;
			this.address = address_;
			this.rating = rating_;
			this.numberOfSales = numberOfSales_;
			this.isAdmin = isAdmin_;
			this.SALT = SALT_;
		}
	}
}