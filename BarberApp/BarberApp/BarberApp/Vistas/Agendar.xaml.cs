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
    public partial class Agendar : ContentPage
    {
        public Agendar()
        {
            InitializeComponent();
        }

        private async void btnVolver_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Gracias","Su cita ha sido programada exitosamente","Ok");
        }
    }
}