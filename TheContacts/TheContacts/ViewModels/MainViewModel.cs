using Bogus;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TheContacts.Models;
using Xamarin.Forms.Internals;

namespace TheContacts.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {
        private Contact selectedContact;

        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
        public Contact SelectedContact
        {
            get => selectedContact; 
            set
            {
                selectedContact = value;
                CoreMethods.PushPageModel<ContactDetailsViewModel>(value);
            }
        }
        public MainViewModel()
        {
        }

        public override async void Init(object initData)
        {
            Contacts = await GetData();
        }

        public async Task<ObservableCollection<Contact>> GetData()
        {
            await Task.Delay(5000);
            var contacts = new Faker<Contact>()
                    .RuleFor(x => x.Name, f => f.Name.FullName())
                    .RuleFor(x => x.Phone, f => f.Phone.PhoneNumber())
                    .Generate(25);
            foreach (var contact in contacts)
            {
                contact.Photo = "Profile.gif";
            }
            //Contacts = new ObservableCollection<Contact>(contacts);
            return new ObservableCollection<Contact>(contacts);
        }
    }
}
