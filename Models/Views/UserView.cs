using System;

namespace Holism.Contacts.Models
{
    public class UserView : Holism.Models.IGuidEntity
    {
        public UserView()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid Guid { get; set; }

        public string Email { get; set; }

        public bool? IsEmailVerified { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DisplayValue { get; set; }

        public DateTime? LastSyncDate { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
