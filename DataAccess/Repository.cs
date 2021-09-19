using Holism.Contacts.Models;
using Holism.DataAccess;

namespace Holism.Contacts.DataAccess
{
    public class Repository
    {
        public static Repository<Contact> Contact
        {
            get
            {
                return new Holism.DataAccess.Repository<Contact
                >(new ContactsContext());
            }
        }

        public static Repository<Address> Address
        {
            get
            {
                return new Holism.DataAccess.Repository<Address
                >(new ContactsContext());
            }
        }

        public static Repository<AddressLocation> AddressLocation
        {
            get
            {
                return new Holism.DataAccess.Repository<AddressLocation
                >(new ContactsContext());
            }
        }

        public static Repository<Phone> Phone
        {
            get
            {
                return new Holism.DataAccess.Repository<Phone
                >(new ContactsContext());
            }
        }
    }
}
