namespace Holism.Contacts.Models;

public class Contact : IGuidEntity
{
    public Contact()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public Guid? UserGuid { get; set; }

    public dynamic RelatedItems { get; set; }
}
