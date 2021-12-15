namespace Holism.Contacts.Models;

public class ProfileView : IGuidEntity
{
    public ProfileView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public long ContactId { get; set; }

    public Guid ContactGuid { get; set; }

    public Guid? UserGuid { get; set; }

    public dynamic RelatedItems { get; set; }
}
