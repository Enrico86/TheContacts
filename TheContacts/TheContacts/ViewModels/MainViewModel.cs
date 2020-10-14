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
                //selectedContact = value;
                //CoreMethods.PushPageModel<ContactDetailsViewModel>(value);

                //Navegación en formato modal
                //var contactDetails = FreshPageModelResolver.ResolvePageModel<ContactDetailsViewModel>(value);
                //var basicNavContainer = new FreshNavigationContainer(contactDetails, "contactsNavPage");
                //CoreMethods.PushNewNavigationServiceModal(basicNavContainer, contactDetails.GetModel());

                //var tabbed = new FreshTabbedNavigationContainer("secondNavPage");
                //tabbed.AddTab<ContactDetailsViewModel>("Details", null, value);
                //tabbed.AddTab<AboutViewModel>("About", null);
                //CoreMethods.PushNewNavigationServiceModal(tabbed);

                var masterDetail = new FreshMasterDetailNavigationContainer("secondNavPage");
                masterDetail.AddPage<ContactDetailsViewModel>("Details", value);
                masterDetail.AddPage<AboutViewModel>("About");
                masterDetail.Init("Menu");
                CoreMethods.PushNewNavigationServiceModal(masterDetail);
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

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);          
        }
        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
        }


    }
}
