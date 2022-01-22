namespace Holism.Contacts.Models;

public class Phone : IGuidEntity
{
    public Phone()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public long ContactId { get; set; }

    public Guid? CountryGuid { get; set; }

    public string PhoneValue { get; set; }

    public dynamic RelatedItems { get; set; }
}
