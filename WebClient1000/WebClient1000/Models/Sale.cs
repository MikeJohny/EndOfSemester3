using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient1000.Models
{
	public class Sale
	{
		public int Id { get; set; }
		public string UsersId { get; set; }
		public int ProductsId { get; set; }
		public string Description { get; set; }
		public int CurrentPrice { get; set; }
		public string HighestBidderId { get; set; }
		public int TimeRemaining { get; set; }
		public bool IsActive { get; set; }
		public string Name { get; set; }
		public string Location { get; set; }
		public int ProductTypes_id { get; set; }

		public Sale()
		{
		}
		public Sale(int id, string usersId, int productsId, string description,
			int currentPrice, string highestBidderId, int timeRemaining, bool isActive)
		{
			this.Id = id;
			this.UsersId = usersId;
			this.ProductsId = productsId;
			this.Description = description;
			this.CurrentPrice = currentPrice;
			this.HighestBidderId = highestBidderId;
			this.TimeRemaining = timeRemaining;
			this.IsActive = isActive;
		}
	}
}