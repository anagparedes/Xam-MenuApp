using System.ComponentModel;
using MenuApp.Models;
using Xamarin.Forms;

namespace MenuApp.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        

        public event PropertyChangedEventHandler PropertyChanged;

        public MenuOption Option1 { get; }
        public MenuOption Option2 { get; }
        public MenuOption Option3 { get; }
        public MenuOption Option4 { get; }
        public MenuOption Option5 { get; }
        public MenuOption Option6 { get; }
        public HomeViewModel()
        {
            Option1 = new MenuOption("Bars & Hotels", "beer.png", "42 Place");
            Option2 = new MenuOption("Cafes", "shops.png", "28 Place");
            Option3 = new MenuOption("Fast Foods", "burger.png", "29 Place");
            Option4 = new MenuOption("Fine Dining", "dish.png", "15 Place");
            Option5 = new MenuOption("Nearby", "destination.png", "34 Place");
            Option6 = new MenuOption("Featured Foods","pizza.png", "21 Place");

        }

        
    }
}