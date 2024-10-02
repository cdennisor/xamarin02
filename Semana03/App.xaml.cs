using Semana03.View;
using Semana03.View.Home;
using Semana03.View.Home.Flyout;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana03
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutMainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
