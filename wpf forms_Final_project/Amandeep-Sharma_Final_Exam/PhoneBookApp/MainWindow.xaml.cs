using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhoneBookApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<PhoneBookListing> searchResult = new List<PhoneBookListing>();
		public MainWindow()
		{
			InitializeComponent();
			phoneBookListingGrid.ItemsSource = PhoneBook.Listings;
		}

		private void AddToList_Click(object sender, RoutedEventArgs e)
		{
			PhoneBook.Listings.Add(new PhoneBookListing(lastNameTextBox.Text, firstNameTextBox.Text, phoneNumberTextBox.Text));
			RefreshPhoneBookListing();
		}
		private void RefreshPhoneBookListing()
		{
			phoneBookListingGrid.ItemsSource = PhoneBook.Listings.ToList();

		}

		private void RemoveFromoList_Click(object sender, RoutedEventArgs e)
		{
			PhoneBookListing _phoneBookListing = (PhoneBookListing)phoneBookListingGrid.SelectedItem;
			if (_phoneBookListing != null)
			{
				PhoneBook.Listings.Remove(_phoneBookListing);
				RefreshPhoneBookListing();
			}
			else
			{
				MessageBox.Show("Please select entry to remove");
			}
		}

		private void SearchPhonebook_Click(object sender, RoutedEventArgs e)
		{
			string searchlastName = searchLastNameTextBox.Text;
			string lastName;
			foreach (PhoneBookListing phl in PhoneBook.Listings)
			{
				lastName = phl.LastName;
				if(searchlastName==lastName)
					searchResult.Add(new PhoneBookListing(phl.LastName,phl.FirstName,phl.PhoneNumber));
				
			}
			if(searchResult.Count==0)
			{
				
					MessageBox.Show("No Data Found");
				
			}

			searchPhoneBookListingGrid.ItemsSource = searchResult;
		}
	}
}
