using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndOfSemester3.Models
{
	public class ProductTypes
	{
		public int Id { get; set; }
		public string Type { get; set; }

		public ProductTypes()
        {
        }
		public ProductTypes(int id, string type)
		{
			this.Id = id;
			this.Type = type;
		}
	}
}