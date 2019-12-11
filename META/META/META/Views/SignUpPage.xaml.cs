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
    public partial class SignUpPage : ContentPage
    {
        SignUpViewModel signUpViewModel;

        public SignUpPage()
        {
            InitializeComponent();
            signUpViewModel = new SignUpViewModel();
            //set binding    
            BindingContext = signUpViewModel;
        }
    }
}