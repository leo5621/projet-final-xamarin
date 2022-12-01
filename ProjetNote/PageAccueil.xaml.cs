﻿using System;
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
        public PageAccueil()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Notes(), true);

        }
    }
}