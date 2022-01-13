using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Bila_Radu_Lab12Xamarin.Data;

namespace Bila_Radu_Lab12Xamarin
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
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
