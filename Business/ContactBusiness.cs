namespace Contacts;

public class ContactBusiness : Business<Contact, Contact>
{
    protected override Write<Contact> Write => Repository.Contact;

    protected override Read<Contact> Read => Repository.Contact;

}