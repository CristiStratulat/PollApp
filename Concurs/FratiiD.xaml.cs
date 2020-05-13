using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Concurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FratiiD : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public FratiiD()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}