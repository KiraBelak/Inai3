using Inai3.NewFolder;
using Inai3.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inai3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();



            MainPage = new Partidos();

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
