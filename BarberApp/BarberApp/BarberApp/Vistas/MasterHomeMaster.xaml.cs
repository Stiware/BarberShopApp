using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BarberApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterHomeMaster : ContentPage
    {
        public ListView ListView;

        public MasterHomeMaster()
        {
            InitializeComponent();

            BindingContext = new MasterHomeMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterHomeMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterHomeMasterMenuItem> MenuItems { get; set; }

            public MasterHomeMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterHomeMasterMenuItem>(new[]
                {
                    new MasterHomeMasterMenuItem { Id = 0, Title = "Page 1" },
                    new MasterHomeMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MasterHomeMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MasterHomeMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MasterHomeMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}