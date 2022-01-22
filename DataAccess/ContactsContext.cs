namespace Contacts;

public class ContactsContext : DatabaseContext
{
    public override string ConnectionStringName => "Contacts";

    public DbSet<Address> Addresses { get; set; }

    public DbSet<AddressLocation> AddressLocations { get; set; }

    public DbSet<Contact> Contacts { get; set; }

    public DbSet<Phone> Phones { get; set; }

    public DbSet<Profile> Profiles { get; set; }

    public DbSet<ProfileView> ProfileViews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Profile>()
            .Property(p => p.FullName)
            .HasComputedColumnSql("concat(ifnull(FirstName, ''), ' ', ifnull(LastName, ''))");
        base.OnModelCreating(builder);
    }
}
