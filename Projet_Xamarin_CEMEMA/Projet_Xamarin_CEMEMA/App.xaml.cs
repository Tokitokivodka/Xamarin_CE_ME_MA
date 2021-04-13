using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Xamarin_CEMEMA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NavigationBarPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
