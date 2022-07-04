using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DanilMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void lblRegister_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            if ((App.User = App.DB.GetUser(etrName.Text, etrPassword.Text)) != null)
                await Navigation.PushAsync(new ExpensesPage());
        }

        private void btnShowPassword_Clicked(object sender, EventArgs e)
        {
            etrPassword.IsPassword = !etrPassword.IsPassword;
        }
    }
}