using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace oop2ödevv
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AraçTipi());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

