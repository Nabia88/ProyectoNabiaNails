using NabiaNailsMaui.Views;


namespace NabiaNailsMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

        }
    }
}
