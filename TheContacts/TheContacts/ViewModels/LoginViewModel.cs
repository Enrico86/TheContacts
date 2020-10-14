using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TheContacts.Enums;
using TheContacts.Services;
using Xamarin.Forms;

namespace TheContacts.ViewModels
{
    public class LoginViewModel: FreshBasePageModel
    {
        public ICommand LoginCommand { get; set; }

        INavigationService _navigationService;

        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public override void Init(object initData)
        {
            LoginCommand = new Command(async () =>
            {
                //await CoreMethods.PushPageModel<MainViewModel>();
                _navigationService.SwitchNavigation(NavigationStacks.MasterDetail, this);
            });
        }
    }
}
