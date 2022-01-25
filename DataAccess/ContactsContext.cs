namespace Contacts;

public class ContactsContext : DatabaseContext
{
    public override string ConnectionStringName => "Contacts";

    public DbSet<Contacts.Address> Addresses { get; set; }

    public DbSet<Contacts.AddressLocation> AddressLocations { get; set; }

    public DbSet<Contacts.Contact> Contacts { get; set; }

    public DbSet<Contacts.Phone> Phones { get; set; }

    public DbSet<Contacts.Profile> Profiles { get; set; }

    public DbSet<Contacts.ProfileView> ProfileViews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Profile>()
            .Property(p => p.FullName)
            .HasComputedColumnSql("concat(ifnull(FirstName, ''), ' ', ifnull(LastName, ''))");
        base.OnModelCreating(builder);
    }
}
