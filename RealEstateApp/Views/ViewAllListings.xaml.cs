namespace RealEstateApp;
using RealEstateApp.Controllers;
using RealEstateApp.Models;

public partial class ViewAllListings : ContentPage
{
    ListingController controller = new();
	public ViewAllListings()
	{
		InitializeComponent();
	}

    private void ViewAllListingsSearch_Clicked(object sender, EventArgs e)
    {
        ListViewAllListings.ItemsSource = null;
        ListViewAllListings.ItemsSource = controller.GetAllListings();
    }
}