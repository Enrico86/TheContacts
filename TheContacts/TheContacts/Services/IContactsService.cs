using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TheContacts.Models;

namespace TheContacts.Services
{
    public interface IContactsService
    {
        Task<ObservableCollection<Contact>> GetData();
    }
}
