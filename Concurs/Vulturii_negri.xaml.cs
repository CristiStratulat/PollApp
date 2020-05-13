using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Diagnostics;
using System.Timers;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Concurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vulturii_negri : ContentPage
    {
        FirebaseClient firebase = new FirebaseClient("https://ies7-13079.firebaseio.com");
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        bool wasClicked { get; set; }
        public Vulturii_negri()
        {
            InitializeComponent();
            wasClicked = false;
            BindingContext = this;

        }
        public Timer aTimer = new Timer();
        private async void ImageButton_Clicked(object sender, System.EventArgs e)
        {
            btn.IsEnabled = false;
            
            aTimer.Elapsed += ATimer_Elapsed;
            aTimer.Interval = 10000;
            aTimer.Enabled = true;
            FirebaseHelper a = new FirebaseHelper();
            int voturi = Convert.ToInt32(await a.GetVotes());
            voturi = voturi + 1;
            await firebase.Child("Vulturii_negri/Voturi").PutAsync(voturi);
            
        }

        private void ATimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Debug.WriteLine("im in");
            btn.IsEnabled = true;
            aTimer.Stop();
        }
    }
}