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
    public partial class FicheRdv : ContentPage
    {

        public FicheRdv()
        {
            InitializeComponent();
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            Rdv leRdv = new Rdv();
            
            var request = new RestRequest("api/v1/RendezVous/1", Method.Get);
            request.AddHeader("Authorization", "Bearer " + App.user.token);
            var asyncResponse = await App.restClient.ExecuteAsync<string>(request);

            leRdv = JsonConvert.DeserializeObject<Rdv>(asyncResponse.Content);

            this.Lb_urgence.Text = "Urgence ? "+leRdv.urgence.ToString();
            this.Lb_duree.Text = "Duree :"+leRdv.duree.ToString();
            this.Lb_heure.Text = "Date du rendez-vous :"+leRdv.dateRendezVous.ToString();
            this.Lb_Patient.Text = "id du patient :"+leRdv.patientId.ToString();
            this.Lb_patientPris.Text = "Le patient est-il vu ?"+leRdv.estVu.ToString();
            this.Lb_Libelle.Text = "Libelle :"+leRdv.libelle.ToString();



        }
    }
}