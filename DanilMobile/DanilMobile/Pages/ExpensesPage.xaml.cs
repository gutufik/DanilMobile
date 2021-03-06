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
    public partial class ExpensesPage : ContentPage
    {
        public List<Expense> Expenses { get; set; }
        public ExpensesPage()
        {
            InitializeComponent();
            Expenses = App.DB.GetExpenses(App.User.Id);
            App.DB.Refresh += RefreshList;
            BindingContext = this;
        }


        private async void lvExpenses_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new Pages.ExpensePage(lvExpenses.SelectedItem as Expense));
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.ExpensePage());
        }

        public void RefreshList()
        {
            Expenses = App.DB.GetExpenses(App.User.Id);
            lvExpenses.ItemsSource = Expenses;
        }
    }
}