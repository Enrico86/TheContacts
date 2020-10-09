using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using TheContacts.Models;

namespace TheContacts.ViewModels
{
    public class ContactDetailsViewModel: FreshBasePageModel
    {

        public override void Init(object initData)
        {
            if (initData is Contact)
            {
                Profile = initData as Contact;
            }
        }
        public Contact Profile { get; set; }

    }
}
