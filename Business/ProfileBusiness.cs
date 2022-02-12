namespace Contacts;

public class ProfileBusiness : Business<ProfileView, Profile>
{
    protected override Write<Profile> Write => Repository.Profile;

    protected override Read<ProfileView> Read => Repository.ProfileView;

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
