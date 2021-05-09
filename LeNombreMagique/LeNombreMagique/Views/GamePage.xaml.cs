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
    public partial class GamePage : ContentPage
    {
        const int num_max = 10;
        const int num_min = 1;
      readonly int magicNumber;
        const int NOMBREDEVIE = 3;
        int nombredevies = NOMBREDEVIE;
        int numeroEntre;

        public GamePage()
        {
       
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            magicNumber = new Random().Next(num_min, num_max);
            minMaxLabel.Text = "Entre " + num_min + " et " + num_max;

        }

        private void Deviner_Clicked(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(numberEntry.Text))
            {
                DisplayAlert("ERREUR!!!", "Vous devez entrer un nombre", "ok");
                return;
            }

            try
            {
                 numeroEntre = Int32.Parse(numberEntry.Text);
            }
            catch(Exception)
            {
                DisplayAlert("ERREUR!!!", "Vous devez entrer uniquement des chiffres", "ok");
                return;
            }
            if (numeroEntre > num_max || numeroEntre < num_min)
                {
                    DisplayAlert("Oups", "Vous devez entrer un numero entre " + num_min + " et " + num_max + "", "ok");
                    return;
                }
            {
                if (magicNumber > numeroEntre)
                {
                    DisplayAlert("oups", "Le nombre magique est plus grand que " + numeroEntre, "ok");
                    return;
                }
                if (magicNumber < numeroEntre)
                {
                    DisplayAlert("oups", "Le nombre magique est plus petit que " + numeroEntre, "ok");
                    return;
                }
                if (magicNumber == numeroEntre)
                {
#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
                    WinAction();
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
                }


            }

             
         }

        private async Task WinAction()
        {   
            await Navigation.PushAsync(new WinPage(magicNumber));

           

            //await DisplayAlert("Bravo", "Vous avez trouver le bon numero " + numeroEntre, "ok");
           // await this.Navigation.PopAsync();

        }

    }
}