using System.Collections.Generic;
using Holism.Contacts.Models;
using Holism.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Holism.Contacts.DataAccess
{
    public class ContactsContext : DatabaseContext
    {
        public override string ConnectionStringName => "Contacts";

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<AddressLocation> AddressLocations { get; set; }

        public DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
