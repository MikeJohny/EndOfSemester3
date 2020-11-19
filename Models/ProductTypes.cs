using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndOfSemester3.Models
{
	public class ProductTypes
	{
		public int id { get; set; }
		public string type { get; set; }

		public ProductTypes()
        {
        }
		public ProductTypes(int id_, string type_)
		{
			this.id = id_;
			this.type = type_;
		}
	}
}