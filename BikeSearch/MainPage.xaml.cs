using System.Threading.Tasks;
using Xamarin.Forms;

namespace BikeSearch
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadItemsAsync();
        }

        private async Task LoadItemsAsync()
        {
            this.bikesList.IsRefreshing = true;
            this.bikesList.ItemsSource = await CraigsHelper.SearchAsync("bike");
            this.bikesList.IsRefreshing = false;
            this.bikesList.EndRefresh();
        }
    }
}
