using Firebase.Database;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Firebase.Database.Query;

namespace Concurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeSquad : ContentPage
    {
        public DateTime dt;
        FirebaseClient firebase = new FirebaseClient("https://ies7-13079.firebaseio.com");
        public ICommand TapCommand => new Command<string>(async(url)=>await Launcher.OpenAsync(url));
        public HomeSquad()
        {
            InitializeComponent();
            BindingContext = this;
            DateTime currentdate = DateTime.Now;
            bool haskey = Preferences.ContainsKey("HomeSquad");
            if (haskey)
            {
                string date = Preferences.Get("HomeSquad", "");
                if (date != null)
                {
                    dt = Convert.ToDateTime(date);
                    TimeSpan timediff = currentdate - dt;

                    if (timediff.Days < 1)
                    {
                        myBtn.IsEnabled = false;
                        DisplayAlert("VOTAT", "URMATORUL VOT POSIBIL: " + dt.AddDays(1).ToShortDateString() + " LA ORA: " + dt.AddDays(1).ToShortTimeString(), "OK");
                    }
                }
            }
            myBtn.Clicked += MyBtn_Clicked;
        }

        private async void MyBtn_Clicked(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            await DisplayAlert("Multumim pentru vot!", "Urmatorul tau vot este poisbil in data de: " + dt.AddDays(1).ToShortDateString() + " la ora: " + dt.AddDays(1).ToShortTimeString(), "Ok");
            int voturi = Convert.ToInt32(await firebase.Child("HomeSquad/Voturi").OnceSingleAsync<int>());
            voturi = voturi + 1;
            await firebase.Child("HomeSquad/Voturi").PutAsync(voturi);
            myBtn.IsEnabled = false;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            string clickdate = dt.ToString();
            Preferences.Set("HomeSquad", clickdate);
        }
    }
}