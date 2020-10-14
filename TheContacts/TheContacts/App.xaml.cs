using Acr.UserDialogs;
using FreshMvvm;
using System;
using TheContacts.Helpers;
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

            //Navegación de tipo ContentPages
            //var initialPage = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
            //MainPage = new FreshNavigationContainer(initialPage);

            //Navegación de tipo MasterDetails
            //var masterDetails = new FreshMasterDetailNavigationContainer();
            //masterDetails.AddPage<MainViewModel>("Contacts");
            //masterDetails.AddPage<AboutViewModel>("About");
            //masterDetails.Init("Menu");
            //MainPage = masterDetails;

            //Navegación de tipo TabbedPage "normal"
            //var tabbed = new FreshTabbedNavigationContainer();
            //tabbed.AddTab<MainViewModel>("Contacts",null);
            //tabbed.AddTab<AboutViewModel>("About", null);
            //MainPage = tabbed;

            //Navegación de tipo FOTabbedPage
            //var tabbed = new FreshTabbedFONavigationContainer("Contacts");
            //tabbed.AddTab<MainViewModel>("Contacts", null);
            //tabbed.AddTab<AboutViewModel>("About", null);
            //MainPage = tabbed;

            //Navegación con multiples pilas de navegación
            var initialPage = FreshPageModelResolver.ResolvePageModel<LoginViewModel>();
            MainPage = new FreshNavigationContainer(initialPage);

            //Varios contenedores de navegación (FreshContainers) dentro de un único contenedor (MasterDetailsPage de XamarinForms)
            //var masterDetail = new MasterDetailPage();
            //var mainPage = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
            //mainPage.Title = "Contacts";

            //var masterPage = new FreshNavigationContainer(mainPage, "masterPage");
            //masterPage.Title = "Menu";
            //masterDetail.Master = masterPage;

            //var about = FreshPageModelResolver.ResolvePageModel<AboutViewModel>();
            //about.Title = "About";
            //var detailPage = new FreshNavigationContainer(about, "detailPage");
            //masterDetail.Detail = detailPage;

            //MainPage = masterDetail;
        }
        
        private void ConfigureContainer()
        {
            FreshIOC.Container.Register<IContactsService, ContactsService>();
            FreshIOC.Container.Register<IUserDialogs>(UserDialogs.Instance);
            FreshIOC.Container.Register<INavigationService>(NavigationHelper.Instance); 
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
