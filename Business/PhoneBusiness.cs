using Holism.Contacts.DataAccess;

namespace Holism.Contacts.Business;

public class PhoneBusiness : Business<Phone, Phone>
{
    protected override Repository<Phone> ReadRepository => Repository.Phone;

    protected override Repository<Phone> WriteRepository => Repository.Phone;
}