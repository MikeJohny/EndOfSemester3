using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient1000.Models
{
	public class ProductTypes
	{
		public int Id { get; set; }
		public string type { get; set; }

		public ProductTypes()
        {
        }
		public ProductTypes(int id_, string type_)
		{
			this.Id = id_;
			this.type = type_;
		}
	}
}