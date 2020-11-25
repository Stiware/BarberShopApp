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
    public partial class Barberos : ContentPage
    {
        public Barberos()
        {
            InitializeComponent();
        }


        private  void Button_Clicked_1(object sender, EventArgs e)
        {
             Navigation.PushModalAsync(new Agendar());
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
             Navigation.PopModalAsync();
        }
    }
}