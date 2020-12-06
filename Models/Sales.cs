using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndOfSemester3.Models
{
	public class Sales
	{
		public int id { get; set; }
		public string users_id { get; set; }
		public int products_id { get; set; }
		public string description { get; set; }
		public int currentPrice { get; set; }
		public string highestBidder_id { get; set; }
		public TimeSpan timeRemaining { get; set; }
		public bool isActive { get; set; }

		public Sales()
        {
        }
		public Sales(int id_, string users_id_, int products_id_, string description_, 
			int currentPrice_, string highestBidder_id_, TimeSpan timeRemaining_, bool isActive_)
		{
			this.id = id_;
			this.users_id = users_id_;
			this.products_id = products_id_;
			this.description = description_;
			this.currentPrice = currentPrice_;
			this.highestBidder_id = highestBidder_id_;
			this.timeRemaining = timeRemaining_;
			this.isActive = isActive_;
		}
	}
}