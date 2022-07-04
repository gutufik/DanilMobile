using DanilMobile.Pages;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DanilMobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ExpensesPage), typeof(ExpensesPage));
            Routing.RegisterRoute(nameof(CategoryPage), typeof(CategoryPage));
        }
    }
}
