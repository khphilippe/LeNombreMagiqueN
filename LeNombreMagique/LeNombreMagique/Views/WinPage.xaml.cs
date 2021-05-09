using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeNombreMagique.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinPage : ContentPage
    {
        public WinPage(int nombreMagique)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            numberMagicLabel.Text = "Le nombre magique etait " + nombreMagique;
            GagneEtRetourne();

            main.Scale = 0.7;
            main.ScaleTo(1.0, 1500, Easing.BounceIn);
        }

        private async Task GagneEtRetourne()
        {
            await Task.Delay(3000);
           await Navigation.PopToRootAsync();
        }
    }
}