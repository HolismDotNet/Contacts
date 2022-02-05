namespace Contacts;

public class Phone : IEntity, IGuid
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
