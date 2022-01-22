namespace Holism.Contacts.UserApi;

public class PhoneController : Controller<Phone, Phone>
{
    public override ReadBusiness<Phone> ReadBusiness => new PhoneBusiness();

    public override Business<Phone, Phone> Business => new PhoneBusiness();
}