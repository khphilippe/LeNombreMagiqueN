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
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            InfiniteSclale(Jouer, 1000);

        }

        
        private async Task InfiniteSclale(View view, uint length)
        {
            bool toujours = true;
            while (toujours)
            {
                await view.ScaleTo(1.1, length);
            await  view.ScaleTo(1.0, length);
             //   view.Scale=1.0;
            }
        }

        private void Jouer_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GamePage());
        }
    }
}