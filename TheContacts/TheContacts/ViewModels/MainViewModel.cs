using Acr.UserDialogs;
using Bogus;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TheContacts.Models;
using TheContacts.Services;
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

        IContactsService _service;
        IUserDialogs _dialogsService;
        public MainViewModel(IContactsService service, IUserDialogs dialogs)
        {
            _service = service;
            _dialogsService = dialogs;
        }

        public override async void Init(object initData)
        {
            _dialogsService.ShowLoading("Cargando");
            var temp = await _service.GetData();
            Contacts = temp;
            _dialogsService.HideLoading();
        }


    }
}
