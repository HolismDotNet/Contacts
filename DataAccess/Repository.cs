namespace Holism.Contacts.DataAccess;

public class Repository
{
    public static Repository<Address> Address
    {
        get
        {
            return new Repository<Address>(new ContactsContext());
        }
    }

    public static Repository<AddressLocation> AddressLocation
    {
        get
        {
            return new Repository<AddressLocation>(new ContactsContext());
        }
    }

    public static Repository<Contact> Contact
    {
        get
        {
            return new Repository<Contact>(new ContactsContext());
        }
    }

    public static Repository<Phone> Phone
    {
        get
        {
            return new Repository<Phone>(new ContactsContext());
        }
    }    public static Repository<Profile> Profile
    {
        get
        {
            return new Repository<Profile>(new ContactsContext());
        }
    }


}
