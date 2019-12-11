using META.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace META
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //set your login page as first page
            //set HomePage as new MainPage
            MainPage = new NavigationPage(new LogInPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
