using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetNote
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Imc : ContentPage
    {
        public Imc()
        {
            InitializeComponent();
        }

        private void calculerButton_Clicked(object sender, EventArgs e)
        {
            //si les champs sont vides :
            if(tailleEntry.Text == null) {
                DisplayAlert("Erreur", "remplir le champ taille", "OK");
            }
            if (poidsEntry.Text == null)
            {
                DisplayAlert("Erreur", "remplir le champ poids", "OK");
            }

            //calcul IMC
            double valeurIMC = Math.Round( ( Convert.ToDouble(poidsEntry.Text)  / ((Convert.ToDouble(tailleEntry.Text) / 100) * (Convert.ToDouble(tailleEntry.Text) / 100)) ), 2);

            resultatCalculImc.Text = Convert.ToString(valeurIMC);
            resultatCalculImc.Text += " : ";

            if (valeurIMC < 16.5)
            {
                resultatCalculImc.Text += "Maigreur morbide";
                photoIMC.Source = ImageSource.FromFile("A1");
            }
            else if (valeurIMC < 18.5 && valeurIMC >16.5)
            {
                resultatCalculImc.Text += "Maigreur";
                photoIMC.Source = ImageSource.FromFile("A2");
            }
            else if (valeurIMC < 25 && valeurIMC > 18.5)
            {
                resultatCalculImc.Text += "Poids normal";
                photoIMC.Source = ImageSource.FromFile("A3");
            }
            else if (valeurIMC < 30 && valeurIMC > 25)
            {
                resultatCalculImc.Text += "Surpoids";
                photoIMC.Source = ImageSource.FromFile("A4");
            }
            else if (valeurIMC < 35 && valeurIMC > 30)
            {
                resultatCalculImc.Text += "Obésité simple";
                photoIMC.Source = ImageSource.FromFile("A5");
            }
            else if (valeurIMC < 40 && valeurIMC > 35)
            {
                resultatCalculImc.Text += "Obésité sévère";
                photoIMC.Source = ImageSource.FromFile("A6");
            }
            else if (valeurIMC > 40)
            {
                resultatCalculImc.Text += "Obésité massive / morbide";
                photoIMC.Source = ImageSource.FromFile("A7");
            }


        }
    }
}