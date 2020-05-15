using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
	static class Store
	{
		static public List<Merchandise> forSale = new List<Merchandise>();
		static int totalPrice;
		static public List<Merchandise> shoppingCart = new List<Merchandise>()
		{
			new Clothing(65,"top"),
		new Clothing(65,"t-shirt"),
		new Clothing(65,"pants"),
		new Clothing(65,"dress"),
		new Clothing(65,"suit"),
		new Food(70,"pizza"),
		new Food(70,"burger"),
		new Food(70,"rice"),
		new Food(70,"icecream"),
		new Food(70,"roll"),
		new Electronics(100,"phone"),
		new Electronics(100,"tv"),
		new Electronics(100,"computer"),
		new Electronics(100,"laptop"),
		new Electronics(100,"mobile")

	};
	}
}
