using System;
using System.Collections.Generic;
using System.Text;
using TheContacts.Services;

namespace TheContacts.Helpers
{
    public static class NavigationHelper
    {
        static INavigationService currentInstance;
        public static INavigationService Instance 
        {
            get
            {
                if (currentInstance == null)
                {
                    currentInstance = new NavigationService();
                    return currentInstance;
                }
                else return currentInstance;
            }
            set
            {
                currentInstance = value;
            }
        }
    }
}
