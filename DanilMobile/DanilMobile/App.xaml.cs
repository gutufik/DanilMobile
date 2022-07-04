using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DanilMobile.Data;
using System.IO;
using DanilMobile.Pages;

namespace DanilMobile
{
    public partial class App : Application
    {
        private static LocalDB db;
        private const string dbName = "LocalDb";

        public static LocalDB DB
        {
            get
            {
                if (db == null)
                    db = new LocalDB(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), dbName));
                return db;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AuthorizationPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}