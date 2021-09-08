using MenuApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPage : ContentPage
    {
        public DiscoveryPage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
    }
}