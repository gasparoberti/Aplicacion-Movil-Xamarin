using AppX.Services;
using AppX.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppX
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

            int count = 0;
            void Button_Clicked(object sender, System.EventArgs e)
            {
                count++;
                ((Button)sender).Text = $"You clicked {count} times.";
            }
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
