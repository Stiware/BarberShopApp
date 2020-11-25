using BarberApp.models;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BarberApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterHomeDetail : ContentPage
    {
        public MasterHomeDetail()
        {
            InitializeComponent();
        }

        ObservableCollection<mediaModels> Photos = new ObservableCollection<mediaModels>();

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //Escala pequeña
            //await ((Frame)sender).ScaleTo(0.8, length: 50, Easing.Linear);
            //Esacala normal
            //await ((Frame)sender).ScaleTo(1, length: 50, Easing.Linear);

            var initialize = await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.IsSupported || !initialize)
            {
                await DisplayAlert("Error", "La camara no se encuentra disponible", "OK");
                return;
            }

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            await DisplayAlert("File Location", file.Path, "OK");

            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });

        }
        
    }
}