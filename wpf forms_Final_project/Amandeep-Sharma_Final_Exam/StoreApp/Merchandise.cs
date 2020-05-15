using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
	abstract class Merchandise
	{
		public int Price { get; set; }
		public string Item { get; set; }
		static public int serialNumber = 0;
		public Merchandise(int price,string item)
		{
			Price = price;
			Item = item;
			serialNumber=serialNumber++;
		}
	}
}
