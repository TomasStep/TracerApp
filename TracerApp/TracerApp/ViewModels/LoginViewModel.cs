using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using TracerApp.Pages;

namespace TracerApp.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {  
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string email;
        private string password;

        public ICommand SubmitCommand { protected set; get; }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (email != "asd@gmail.com" || password != "secret")
            {
                DisplayInvalidLoginPrompt();
                return;
            }else 
            { 
                Application.Current.MainPage = new MainPage();
            }
        }

        public void GoToLogin()
        {
            Application.Current.MainPage = new LoginPage();
        }

        public void GoToScan()
        {
            Application.Current.MainPage = new ScanPage();
        }

        public void GoToMain()
        {
            Application.Current.MainPage = new MainPage();
        }
    }  
}
