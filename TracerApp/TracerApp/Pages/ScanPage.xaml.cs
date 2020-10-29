using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TracerApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TracerApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanPage : ContentPage
    {
        public ScanPage()
        {
            InitializeComponent();
        }

        private void BtnClicked_GoBack(object sender, EventArgs e)
        {
            LoginViewModel vm = new LoginViewModel();

            vm.GoToMain();
        }
    }
}