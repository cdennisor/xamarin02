using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana03.View.Home.Flyout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categorias : ContentPage
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private async void category_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MisCompras());
        }
    }
}