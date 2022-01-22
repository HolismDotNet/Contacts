namespace Contacts;

public class Repository
{
    public static Repository<Contacts.Address> Address
    {
        get
        {
            return new Repository<Contacts.Address>(new ContactsContext());
        }
    }

    public static Repository<Contacts.AddressLocation> AddressLocation
    {
        get
        {
            return new Repository<Contacts.AddressLocation>(new ContactsContext());
        }
    }

    public static Repository<Contacts.Contact> Contact
    {
        get
        {
            return new Repository<Contacts.Contact>(new ContactsContext());
        }
    }

    public static Repository<Contacts.Phone> Phone
    {
        get
        {
            return new Repository<Contacts.Phone>(new ContactsContext());
        }
    }

    public static Repository<Contacts.Profile> Profile
    {
        get
        {
            return new Repository<Contacts.Profile>(new ContactsContext());
        }
    }

    public static Repository<Contacts.ProfileView> ProfileView
    {
        get
        {
            return new Repository<Contacts.ProfileView>(new ContactsContext());
        }
    }
}
