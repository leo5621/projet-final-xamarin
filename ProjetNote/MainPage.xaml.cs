using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetNote
{
    public partial class MainPage : ContentPage
    {

        RestClient restClient = new RestClient("http://51.75.30.4/MediPocket");
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Authentification userLogin = new Authentification(this.login.Text, this.pwd.Text);
            var request = new RestRequest("api/v1/OAuth/authenticate", Method.Post);
            request.AddJsonBody(userLogin);

            var asyncResponse = await restClient.ExecuteAsync<string>(request);

            if (asyncResponse != null)
            {
                var currentLogin = JsonConvert.DeserializeObject<User>(asyncResponse.Content);
                App.user = currentLogin;
                await Navigation.PushModalAsync(new PageAccueil(),true);
            }
            else
            {
                await DisplayAlert("Résultat", "Authentification echouée, veuillez réessayer", null, "ok");
            }

        }

    }

}
