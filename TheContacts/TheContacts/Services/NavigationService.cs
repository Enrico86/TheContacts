using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using TheContacts.Enums;
using TheContacts.Pages;
using TheContacts.ViewModels;
using Xamarin.Forms;

namespace TheContacts.Services
{
    public class NavigationService : INavigationService
    {
        public void SwitchNavigation(NavigationStacks navigationStacks, FreshBasePageModel page)
        {
            switch (navigationStacks)
            {
                case (NavigationStacks.Authentication):
                    var loginPage = FreshPageModelResolver.ResolvePageModel<LoginViewModel>();
                    var authenticationNavContainer = new FreshNavigationContainer(loginPage, navigationStacks.ToString());
                    page.CoreMethods.SwitchOutRootNavigation(navigationStacks.ToString());
                    break;

                case (NavigationStacks.Main):
                    var mainPage = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
                    var mainNavContainer = new FreshNavigationContainer(mainPage, navigationStacks.ToString());
                    page.CoreMethods.SwitchOutRootNavigation(navigationStacks.ToString());
                    break;

                case (NavigationStacks.MasterDetail):
                    var mainMasterDetailContainer = new FreshMasterDetailNavigationContainer(navigationStacks.ToString());
                    mainMasterDetailContainer.AddPage<MainViewModel>("Contacts");
                    mainMasterDetailContainer.AddPage<AboutViewModel>("About");
                    mainMasterDetailContainer.AddPage<LogoutViewModel>("Logout");
                    mainMasterDetailContainer.Init("Menu");
                    page.CoreMethods.SwitchOutRootNavigation(navigationStacks.ToString());
                    break;

                case (NavigationStacks.Tabbed):
                    var tabbedContainer = new FreshTabbedNavigationContainer(navigationStacks.ToString());
                    tabbedContainer.AddTab<MainViewModel>("Contacts", null);
                    tabbedContainer.AddTab<AboutViewModel>("About", null);
                    page.CoreMethods.SwitchOutRootNavigation(navigationStacks.ToString());
                    break;

                case (NavigationStacks.TabbedFO):
                    var tabbedFOContainer = new FreshTabbedFONavigationContainer(navigationStacks.ToString());
                    tabbedFOContainer.AddTab<MainViewModel>("Contacts", null);
                    tabbedFOContainer.AddTab<AboutViewModel>("About", null);
                    page.CoreMethods.SwitchOutRootNavigation(navigationStacks.ToString());
                    break;
            }
        }
    }
}
