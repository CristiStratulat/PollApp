using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Concurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (entry.Text == "skajd")
            {
                await Navigation.PushAsync(new Rezultate());
            }
            else
                await DisplayAlert("PAROLA GRESITA", "PAROLA INTRODUSA ESTE GRESITA!", "OK");
        }
    }
}