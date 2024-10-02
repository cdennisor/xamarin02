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
    public partial class MisCompras : ContentPage
    {
        public MisCompras()
        {
            InitializeComponent();
        }

        private async void btn_back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}