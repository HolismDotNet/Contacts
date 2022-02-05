namespace Contacts;

public class Contact : IEntity, IGuid
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
