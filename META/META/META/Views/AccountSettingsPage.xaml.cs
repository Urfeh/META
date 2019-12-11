using META.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace META.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountSettingsPage : ContentPage
    {
        AccountSettingsPageViewModel accountSettingsPageViewModel;
        public AccountSettingsPage(string email)
        {
            InitializeComponent();
            accountSettingsPageViewModel = new AccountSettingsPageViewModel(email);
            BindingContext = accountSettingsPageViewModel;
        }
    }
}