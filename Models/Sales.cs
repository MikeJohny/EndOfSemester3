using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndOfSemester3.Models
{
	public class Sales
	{
		public int id { get; set; }
		public int users_id { get; set; }
		public int products_id { get; set; }
		public bool isBid { get; set; }
		public string description { get; set; }
		public int currentPrice { get; set; }

		public Sales()
        {
        }
		public Sales(int id_, int users_id_, int products_id_, bool isBid_, string description_, int currentPrice_)
		{
			this.id = id_;
			this.users_id = users_id_;
			this.products_id = products_id_;
			this.isBid = isBid_;
			this.description = description_;
			this.currentPrice = currentPrice_;
		}
	}
}