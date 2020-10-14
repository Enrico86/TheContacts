using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using TheContacts.Services;

namespace TheContacts.Pages
{
    public class LogoutViewModel: FreshBasePageModel
    {
        INavigationService _navigationService;
        public LogoutViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            _navigationService.SwitchNavigation(Enums.NavigationStacks.Authentication, this);
        }
    }
}
