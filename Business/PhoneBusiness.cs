namespace Contacts;

public class PhoneBusiness : Business<Phone, Phone>
{
    protected override Read<Phone> Read => Repository.Phone;

    protected override Write<Phone> Write => Repository.Phone;
}