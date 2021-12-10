namespace Holism.Contacts.Models;

public class Profile : IGuidEntity
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

    public dynamic RelatedItems { get; set; }
}
