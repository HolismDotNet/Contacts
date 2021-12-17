using Holism.Contacts.Models;
using Holism.Contacts.DataAccess;

namespace Holism.Contacts.Business;

public class ContactBusiness : Business<Contact, Contact>
{
    protected override Repository<Contact> WriteRepository =>
        Repository.Contact;

    protected override ReadRepository<Contact> ReadRepository =>
        Repository.Contact;

}