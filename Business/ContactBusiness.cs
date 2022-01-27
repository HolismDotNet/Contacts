namespace Contacts;

public class ContactBusiness : Business<Contact, Contact>
{
    protected override Repository<Contact> WriteRepository => RepositoryContact;

    protected override ReadRepository<Contact> ReadRepository => RepositoryContact;

}