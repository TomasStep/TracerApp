using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TracerApp.Pages;
using Xamarin.Forms;
using TracerApp.ViewModels;

namespace TracerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            LoginViewModel vm = new LoginViewModel();

            vm.GoToLogin();
        }
    }
}
