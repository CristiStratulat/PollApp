using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Concurs
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void No_Name(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        async void Vulturii_Negri(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vulturii_negri());
        }

        async void Super_team(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Super_team());
        }

        async void Vestitii(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vestitii());
        }
        async void H_ForEver(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new H());
        }
        async void FratiiD(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FratiiD());
        }
        async void SuperGirls(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SuperGirls());
        }
        async void Campionii(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Campionii());
        }
        async void HomeSquad(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomeSquad());
        }
        async void Bang(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bang());
        }
        async void Vulturii(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vulturii());
        }
        async void Tic(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TiC());
        }
        async void Tiger(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tiger());
        }
        async void Minionline(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Minionline());
        }
        async void Sportivii(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new sportivii());
        }
        async void Panda(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Panda());
        }
        async void Cactusiii(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cactusii());
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Miadi());
        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}
