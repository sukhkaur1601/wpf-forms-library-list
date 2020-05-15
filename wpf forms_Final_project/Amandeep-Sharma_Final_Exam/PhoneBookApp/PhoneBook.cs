using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
	static class PhoneBook
	{
		static public List<PhoneBookListing> Listings = new List<PhoneBookListing> {
			new PhoneBookListing("Sharma","Aman","467-6788"),
			new PhoneBookListing("Samagh","Aman","324-7800"),
			new PhoneBookListing("Sharma","Anu","456-4556"),
			new PhoneBookListing("kaur","kamal","456-8327"),
			new PhoneBookListing("chahal","raman","567-6788"),
			new PhoneBookListing("Sidhu","jugan","234-7788"),
			new PhoneBookListing("kaur","amrit","456-6368"),
			new PhoneBookListing("Sandhu","Sharan","467-6672")
		};

	}
}
