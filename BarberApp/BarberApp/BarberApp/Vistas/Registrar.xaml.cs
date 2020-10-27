using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BarberApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrar : ContentPage
    {
        public Registrar()
        {
            InitializeComponent();
            Rol.SelectedIndex = 0;
        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MasterHome());
        }
    }
}