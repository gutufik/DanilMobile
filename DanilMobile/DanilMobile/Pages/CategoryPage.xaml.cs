using DanilMobile.Data;
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
    public partial class CategoryPage : ContentPage
    {
        public ExpenseType Type { get; set; }
        public CategoryPage()
        {
            InitializeComponent();
            Type = new ExpenseType();

            this.BindingContext = this;
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            App.DB.SaveExpenseType(Type);
            await Navigation.PopAsync();
        }
    }
}