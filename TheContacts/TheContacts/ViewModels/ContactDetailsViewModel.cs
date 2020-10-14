using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TheContacts.Models;
using Xamarin.Forms;

namespace TheContacts.ViewModels
{
    public class ContactDetailsViewModel: FreshBasePageModel
    {
        public Contact Profile { get; set; }
        public ICommand ReturnCommand { get; set; }


        public override void Init(object initData)
        {
            ReturnCommand = new Command(async () =>
            {
                await CoreMethods.PopPageModel(Profile);
            });

            if (initData is Contact)
            {
                Profile = initData as Contact;
            }
        }


    }
}
