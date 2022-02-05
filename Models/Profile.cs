namespace Contacts;

public class Profile : IEntity, IGuid
{
    public Profile()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public long ContactId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string FullName { get; set; }

    public dynamic RelatedItems { get; set; }
}
