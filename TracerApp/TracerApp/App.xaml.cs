using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TracerApp
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
            //MainPage = new Pages.LoginPage();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
