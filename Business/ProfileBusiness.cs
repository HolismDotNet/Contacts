namespace Contacts;

public class ProfileBusiness : Business<ProfileView, Profile>
{
    protected override Repository<Profile> WriteRepository => RepositoryProfile;

    protected override ReadRepository<ProfileView> ReadRepository => RepositoryProfileView;

    public ProfileView Create(string firstName, string lastName)
    {
        var contact = new Contact();
        new ContactBusiness().Create(contact);
        var profile = new Profile();
        profile.ContactId = contact.Id;
        profile.FirstName = firstName;
        profile.LastName = lastName;
        Create(profile);
        return Get(profile.Id);
    }
}
