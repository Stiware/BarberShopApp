﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BarberApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ajustes : ContentPage
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            
            Navigation.PopModalAsync(true);
            
        }
    }
}