using RestSharp;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetNote
{
    public partial class App : Application
    {
        public static User user { get; set; }
        public static RestClient restClient = new RestClient("http://51.75.30.4/MediPocket");

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
