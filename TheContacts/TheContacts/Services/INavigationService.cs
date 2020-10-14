using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using TheContacts.Enums;

namespace TheContacts.Services
{
    public interface INavigationService
    {
        void SwitchNavigation(NavigationStacks navigationStacks, FreshBasePageModel page);
    }
}
