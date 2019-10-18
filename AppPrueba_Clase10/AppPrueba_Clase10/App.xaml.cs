using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppPrueba_Clase10.Services;
using AppPrueba_Clase10.Views;

namespace AppPrueba_Clase10
{
    public partial class App : Application  //App hereda de Application
    {

        public App()
        {
            InitializeComponent(); //Es obligatorio, al principio del constructor

            MainPage = new Index(); 
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
