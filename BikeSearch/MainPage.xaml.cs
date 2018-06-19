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

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var item = (BikeItem)e.SelectedItem;
                this.bikesList.SelectedItem = null;
                Device.OpenUri(new System.Uri(item.Link));
            }
        }
    }
}
