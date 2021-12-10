namespace Holism.Contacts.Models;

public class Address : IGuidEntity
{
    public Address()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public long ContactId { get; set; }

    public Guid CountryGuid { get; set; }

    public Guid? ProvinceOrStateGuid { get; set; }

    public Guid CityGuid { get; set; }

    public string Rest { get; set; }

    public string Remarks { get; set; }

    public dynamic RelatedItems { get; set; }
}
