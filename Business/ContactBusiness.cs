namespace Contacts;

public class ContactBusiness : Business<Contact, Contact>
{
    protected override Repository<Contact> WriteRepository => Repository.Contact;

    protected override ReadRepository<Contact> ReadRepository => Repository.Contact;

}