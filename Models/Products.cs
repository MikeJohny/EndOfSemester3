using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndOfSemester3.Models
{
	public class Products
	{
		public int id { get; set; }
		public string name { get; set; }
		public int startingPrice { get; set; }
		public string location { get; set; }
		public int productTypes_id { get; set; }

		public Products()
		{

		}

		public Products(int id_, string name_, int startingPrice_, string location_, int productTypes_id_)
		{
			this.id = id_;
			this.name = name_;
			this.startingPrice = startingPrice_;
			this.location = location_;
			this.productTypes_id = productTypes_id_;
		}

		
	}
}