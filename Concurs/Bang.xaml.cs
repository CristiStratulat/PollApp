using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Concurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bang : ContentPage
    {
        private DateTime defaultValue;

        public ICommand TapCommand => new Command<string>(async(url)=>await Launcher.OpenAsync(url));
        public Bang()
        {
            InitializeComponent();
            BindingContext = this;
            myBtn.Clicked += MyBtn_Clicked;
            // Debug.WriteLine(votPosibil);
            
        }
        public DateTime votPosibil
        {
            get => Preferences.Get("votPosibil",defaultValue);
            set => Preferences.Set("votPosibil", value);
        }
        private void MyBtn_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine(votPosibil);
            if (DateTime.Compare(DateTime.Now,votPosibil)>=0)
            {
                votPosibil = votPosibil.AddSeconds(30);
                
                DisplayAlert("Multumim pentru vot", "urmatorul vot posibil este la" + votPosibil, "OK");

            }
            else if (DateTime.Compare(DateTime.Now, votPosibil) <0)
            {
                DisplayAlert("VOTAT DEJA", "Ai votat deja. Vot posibil la" + votPosibil, "OK");
            }
        }
    }
}