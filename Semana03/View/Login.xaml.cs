using Semana03.View.Home;
using Semana03.View.Home.Flyout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana03.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btn_ISesion_Clicked(object sender, EventArgs e)
        {
            string user = "cdennis";
            string password = "senati2024";

            string u_ingresado = txtUser.Text;
            string p_ingresado = txtPass.Text;

            if (user == u_ingresado && password == p_ingresado)
            {
                txtMensaje.Text = "";
                txtPass.Text = "";
                txtUser.Text = "";
                await Navigation.PushModalAsync(new FlyoutMainPage());
            }
            else
            {
                txtMensaje.Text = "Usuario o contraseña incorrecta...!!!";
            }
        }
    }
}