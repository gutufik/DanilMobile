using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DanilMobile.Data;


namespace DanilMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public User User { get; set; }
        public RegistrationPage()
        {
            InitializeComponent();
            User = new User();
            Title = "Регистрация";
            BindingContext = User;
        }

        private void btnShowPassword_Clicked(object sender, EventArgs e)
        {
            etrPassword.IsPassword = !etrPassword.IsPassword;
        }

        private void btnShowConfirmPassword_Clicked(object sender, EventArgs e)
        {
            etrConfirmPassword.IsPassword = !etrConfirmPassword.IsPassword;
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRegister_Clicked(object sender, EventArgs e)
        {

        }
    }
}