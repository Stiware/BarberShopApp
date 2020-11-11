using BarberApp.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BarberApp.models;

namespace BarberApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

       
        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;
            }

            clsCache cache = new clsCache();

            cache.Name = txtUsuario.Text;
            cache.IniSesion1 = true;

            Navigation.PushModalAsync(new MasterHome());
        }
        private bool validar()
        {

            if (txtUsuario.Text == null)
            {
                DisplayAlert("AVISO","Debe introducir el usuario iniciar sesion","OK");
                return false;
            }
            if (txtContraseña.Text == null)
            {
                DisplayAlert("AVISO","Debe introducir el la contraseña para iniciar sesion","OK");
                return false;
            }
            return true;
        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Registrar());
        }
    }
}
