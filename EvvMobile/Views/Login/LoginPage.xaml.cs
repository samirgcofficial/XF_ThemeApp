using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EvvMobile.Views.Login
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

       async void LoginButtonPressed_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Dashboard.DashboardPage());
        }
    }
}
