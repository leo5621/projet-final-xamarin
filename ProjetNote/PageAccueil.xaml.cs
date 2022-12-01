using Newtonsoft.Json;
using RestSharp;
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
    public partial class PageAccueil : ContentPage
    {
        public List<Rdv> listeRDVs = new List<Rdv>();
        public PageAccueil()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Notes(), true);

        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            this.listeRDVs.Clear();
            Rdv leRdv = new Rdv();
            leRdv.libelle = "test";

            Rdv leRdv2 = new Rdv();
            leRdv.libelle = "test2";
            listeRDVs.Add(new Rdv());
/*            var request = new RestRequest("api/v1/RendezVous", Method.Get);
            request.AddHeader("Authorization", "Bearer " + App.user.token);
            var asyncResponse = await App.restClient.ExecuteAsync<string>(request);

            await DisplayAlert("Resultat", asyncResponse.Content, null, "ok");
            listeRDVs = JsonConvert.DeserializeObject<string>(asyncResponse.Content);
            list_rss.ItemsSource = listeRDVs.ToArray();*/
                        var query = from Rdv in listeRDVs
                                    select Rdv.libelle;
                        list_rss.ItemsSource = query;

        }

        private async void list_rss_ItemSelected(object sender, FocusEventArgs e)
        {
            Navigation.PushModalAsync(new FicheRdv());
        }

    }
}