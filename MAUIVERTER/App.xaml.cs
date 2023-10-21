using MAUIVERTER.MVVM.Views;
using Microsoft.Maui.Controls;

namespace MAUIVERTER
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuView());
        }
    }
}