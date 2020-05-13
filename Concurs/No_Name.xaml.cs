using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Timers;
using System.Diagnostics;


namespace Concurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public Page1()
        {
            InitializeComponent();
            BindingContext = this;
        }
        
        public void ImageButton_Clicked(object sender, EventArgs e)
        {
            
                Timer aTimer = new Timer();
                myButton.IsEnabled = false;    
                aTimer.Interval = 5000; //ms
                aTimer.Enabled = true;
                aTimer.Elapsed += ATimer_Elapsed;
  
        }

        public void ATimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() => { myButton.IsEnabled = true; });
        }
    }

    
}

