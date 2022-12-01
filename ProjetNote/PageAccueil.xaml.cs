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
    public partial class PageAccueil : CarouselPage
    {
        public PageAccueil()
        {
            InitializeComponent();

            this.SelectedItem = AccueilListe; // Caroussel page du milieu

        }


    }
}