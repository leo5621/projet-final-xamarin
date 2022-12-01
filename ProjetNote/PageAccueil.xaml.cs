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
        public ListeRDV listeRDVs;
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
            var request = new RestRequest("api/v1/RendezVous", Method.Get);
            request.AddHeader("Authorization", "Bearer " + App.user.token);
            var asyncResponse = await App.restClient.ExecuteAsync<string>(request);
            await DisplayAlert("Resultat", asyncResponse.Content, null, "ok");
            listeRDVs = JsonConvert.DeserializeObject<ListeRDV>(asyncResponse.Content);

        }
    }
}