using Java.Sql;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Concurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FratiiD : ContentPage
    {
        public DateTime dt;
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

                    if (timediff.Seconds < 40)
                    {
                        btnvote.IsEnabled = false;
                    }
                }
            }
        }

        private void btnvote_Clicked(object sender, EventArgs e)
        {
            dt = DateTime.Now;

            //save count into database or local
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