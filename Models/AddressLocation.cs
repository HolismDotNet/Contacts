namespace Holism.Contacts.Models;

public class AddressLocation : IEntity
{
    public AddressLocation()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Latitude { get; set; }

    public string Longitude { get; set; }

    public string Location { get; set; }

    public dynamic RelatedItems { get; set; }
}
