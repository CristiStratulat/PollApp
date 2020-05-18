using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Firebase.Database;
using Firebase.Database.Query;

namespace Concurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FratiiD : ContentPage
    {
        public DateTime dt;
        FirebaseClient firebase = new FirebaseClient("https://ies7-13079.firebaseio.com");
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public FratiiD()
        {
            InitializeComponent();
            DateTime currentdate = DateTime.Now;
            BindingContext = this;
            bool haskey = Preferences.ContainsKey("user1");
            if (haskey)
            {
                string date = Preferences.Get("user1", "");
                if (date != null)
                {
                    dt = Convert.ToDateTime(date);
                    TimeSpan timediff = currentdate - dt;  

                    if (timediff.Days< 1)
                    {
                        btnvote.IsEnabled = false;
                        DisplayAlert("VOTAT", "URMATORUL VOT POSIBIL: "+dt.AddDays(1).ToShortDateString()+" LA ORA: "+ dt.AddDays(1).ToShortTimeString(), "OK");
                    }
                }
            }
        }

        private async void btnvote_Clicked(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            await DisplayAlert("Multumim pentru vot!", "Urmatorul tau vot este poisbil in data de: " +dt.AddDays(1).ToShortDateString()+" la ora: " + dt.AddDays(1).ToShortTimeString(), "Ok");
            int voturi = Convert.ToInt32(await firebase.Child("FratiiD/Voturi").OnceSingleAsync<int>());
            voturi = voturi + 1;
            await firebase.Child("FratiiD/Voturi").PutAsync(voturi);

            btnvote.IsEnabled = false;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            string clickdate = dt.ToString();
            Preferences.Set("user1", clickdate);
        }
    }
}