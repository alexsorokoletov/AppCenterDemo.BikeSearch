using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BikeSearch
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("ios=93dd2600-deae-4958-98fc-61e04a13c4a4;" + "uwp={Your UWP App secret here};" + "android={Your Android App secret here}", typeof(Analytics), typeof(Crashes));
        }
    }
}
