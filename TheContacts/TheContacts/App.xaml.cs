using Acr.UserDialogs;
using FreshMvvm;
using System;
using TheContacts.Services;
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
            ConfigureContainer();  
            var initialPage = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
            MainPage = new FreshNavigationContainer(initialPage);
        }

        private void ConfigureContainer()
        {
            FreshIOC.Container.Register<IContactsService, ContactsService>();
            FreshIOC.Container.Register<IUserDialogs>(UserDialogs.Instance);
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
