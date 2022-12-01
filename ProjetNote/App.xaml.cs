using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetNote
{
    public partial class App : Application
    {
        public static User user { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new PageAccueil();
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
