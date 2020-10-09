using FreshMvvm;
using System;
using TheContacts.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheContacts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var initialPage = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
            MainPage = new FreshNavigationContainer(initialPage);
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
