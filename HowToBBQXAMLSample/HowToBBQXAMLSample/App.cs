using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HowToBBQXAMLSample.Views;

using Xamarin.Forms;

namespace HowToBBQXAMLSample
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var recipes = new BBQRecipesPage();
            MainPage = new NavigationPage(recipes);
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
