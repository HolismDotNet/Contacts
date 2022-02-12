namespace Contacts;

public class Repository
{
    public static Write<Contacts.Address> Address
    {
        get
        {
            return new Write<Contacts.Address>(new ContactsContext());
        }
    }

    public static Write<Contacts.AddressLocation> AddressLocation
    {
        get
        {
            return new Write<Contacts.AddressLocation>(new ContactsContext());
        }
    }

    public static Write<Contacts.Contact> Contact
    {
        get
        {
            return new Write<Contacts.Contact>(new ContactsContext());
        }
    }

    public static Write<Contacts.Phone> Phone
    {
        get
        {
            return new Write<Contacts.Phone>(new ContactsContext());
        }
    }

    public static Write<Contacts.Profile> Profile
    {
        get
        {
            return new Write<Contacts.Profile>(new ContactsContext());
        }
    }

    public static Write<Contacts.ProfileView> ProfileView
    {
        get
        {
            return new Write<Contacts.ProfileView>(new ContactsContext());
        }
    }
}
