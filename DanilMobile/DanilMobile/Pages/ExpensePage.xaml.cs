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
    public partial class ExpensePage : ContentPage
    {
        public Expense Expense { get; set; }
        public ExpensePage()
        {
            InitializeComponent();
            Expense = new Expense();
            BindingContext = Expense;
            this.ToolbarItems.Clear();
        }

        public ExpensePage(Expense expense)
        {
            InitializeComponent();
            Expense = expense;
            BindingContext = Expense;
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            App.DB.SaveExpense(Expense);
            await Navigation.PopAsync();
        }

        private void btnDel_Clicked(object sender, EventArgs e)
        {
            App.DB.DeleteExpense(Expense);
        }
    }
}