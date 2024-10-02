using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Semana03.View;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana03.View.Home.Flyout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutMainPageFlyout : ContentPage
    {
        public ListView ListView;

        public FlyoutMainPageFlyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutMainPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class FlyoutMainPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutMainPageFlyoutMenuItem> MenuItems { get; set; }

            public FlyoutMainPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutMainPageFlyoutMenuItem>(new[]
                {
                    new FlyoutMainPageFlyoutMenuItem { Id = 0, Title = "Inicio", Icon="\xf015", TargetType=typeof(FlyoutMainPageDetail) },
                    new FlyoutMainPageFlyoutMenuItem { Id = 1, Title = "Categorias", Icon="\xf5fd", TargetType=typeof(Categorias) },
                    new FlyoutMainPageFlyoutMenuItem { Id = 2, Title = "Ofertas", Icon="\xf02b", TargetType=typeof(Ofertas) },
                    new FlyoutMainPageFlyoutMenuItem { Id = 3, Title = "Mis compras", Icon="\xf00b", TargetType=typeof(MisCompras) },
                    new FlyoutMainPageFlyoutMenuItem { Id = 4, Title = "historial de compras", Icon="\xf00c", TargetType=typeof(Historial) },
                    new FlyoutMainPageFlyoutMenuItem { Id = 4, Title = "Buscar", Icon="\xf002" },
                    new FlyoutMainPageFlyoutMenuItem { Id = 4, Title = "Mi cuenta", Icon="\xf2bd" },
                    new FlyoutMainPageFlyoutMenuItem { Id = 4, Title = "Tiendas oficiales", Icon="\xf54f" },
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

        private async void btn_salir_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();            
        }
    }
}