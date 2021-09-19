using System.Collections.Generic;
using Holism.Contacts.Models;
using Holism.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Holism.Contacts.DataAccess
{
    public class ContactsContext : DatabaseContext
    {
        public override string ConnectionStringName => "Contacts";

        public DbSet<User> Users { get; set; }

        public DbSet<UserView> UserViews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
