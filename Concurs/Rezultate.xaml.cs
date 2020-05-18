using Firebase.Database;
using Firebase.Database.Query;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Concurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rezultate : ContentPage
    {
        FirebaseClient firebase = new FirebaseClient("https://ies7-13079.firebaseio.com/");
        public Rezultate()
        {
            InitializeComponent();
           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            int Noname = Convert.ToInt32(await firebase.Child("No_Name/Voturi").OnceSingleAsync<int>());
            noname.Text = Noname.ToString();
            int Vulturiineggri = Convert.ToInt32(await firebase.Child("Vulturii_negri/Voturi").OnceSingleAsync<int>());
            vulturiinegri.Text = Vulturiineggri.ToString();
            int Superteam = Convert.ToInt32(await firebase.Child("Super_team/Voturi").OnceSingleAsync<int>());
            superteam.Text = Superteam.ToString();
            int Vestitii = Convert.ToInt32(await firebase.Child("Vestitii/Voturi").OnceSingleAsync<int>());
            vestitii.Text = Vestitii.ToString();
            int H = Convert.ToInt32(await firebase.Child("H/Voturi").OnceSingleAsync<int>());
            h.Text = H.ToString();
            int FratiiD = Convert.ToInt32(await firebase.Child("FratiiD/Voturi").OnceSingleAsync<int>());
            fratiid.Text = FratiiD.ToString();
            int Supergirls = Convert.ToInt32(await firebase.Child("SuperGirls/Voturi").OnceSingleAsync<int>());
            supergirls.Text = Supergirls.ToString();
            int CampioniiC = Convert.ToInt32(await firebase.Child("Campionii/Voturi").OnceSingleAsync<int>());
            campioniiC.Text = CampioniiC.ToString();
            int HomeSquad = Convert.ToInt32(await firebase.Child("HomeSquad/Voturi").OnceSingleAsync<int>());
            homesquad.Text = HomeSquad.ToString();
            int BAng = Convert.ToInt32(await firebase.Child("Bang/Voturi").OnceSingleAsync<int>());
            bang.Text = BAng.ToString();
            int VUlturii = Convert.ToInt32(await firebase.Child("Vulturii/Voturi").OnceSingleAsync<int>());
            vulturii.Text = VUlturii.ToString();
            int TICtoc = Convert.ToInt32(await firebase.Child("TiC/Voturi").OnceSingleAsync<int>());
            tictoc.Text = TICtoc.ToString();
            int Tiger = Convert.ToInt32(await firebase.Child("Tiger/Voturi").OnceSingleAsync<int>());
            tiger.Text = Tiger.ToString();
            int miNi = Convert.ToInt32(await firebase.Child("Minionline/Voturi").OnceSingleAsync<int>());
            minionline.Text = miNi.ToString();
            int Sportivii = Convert.ToInt32(await firebase.Child("Sportivii/Voturi").OnceSingleAsync<int>());
            sportivii.Text = Sportivii.ToString();
            int Panda = Convert.ToInt32(await firebase.Child("Panda/Voturi").OnceSingleAsync<int>());
            panda.Text =Panda.ToString();
            int Kactusii= Convert.ToInt32(await firebase.Child("Cactusii/Voturi").OnceSingleAsync<int>());
            cactusii.Text = Kactusii.ToString();
            int Miadi = Convert.ToInt32(await firebase.Child("Miadi/Voturi").OnceSingleAsync<int>());
            miadi.Text = Miadi.ToString();

        }
    }
}