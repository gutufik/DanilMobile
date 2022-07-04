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
        public List<string> RecordTypes { get; set; } = new List<string> { "Доход", "Расход" };
        public List<string> ExpenseTypes { get; set; } = new List<string> { "Тип1", "Тип2", "Тип3" };
        public ExpensePage()
        {
            InitializeComponent();
            Expense = new Expense();
            BindingContext = Expense;
            pickExpenseType.ItemsSource = ExpenseTypes;
            pickRecordType.ItemsSource = RecordTypes;
            this.ToolbarItems.Clear();
        }

        public ExpensePage(Expense expense)
        {
            InitializeComponent();
            Expense = expense;
            pickExpenseType.ItemsSource = ExpenseTypes;
            pickRecordType.ItemsSource = RecordTypes;
            BindingContext = Expense;
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            Expense.ExpenseType = pickExpenseType.SelectedItem.ToString();
            Expense.RecordType = pickRecordType.SelectedItem.ToString();
            App.DB.SaveExpense(Expense);
            await Navigation.PopAsync();
        }

        private void btnDel_Clicked(object sender, EventArgs e)
        {
            App.DB.DeleteExpense(Expense);
        }
    }
}