using System;

namespace Holism.Contacts.Models
{
    public class Profile : Holism.Models.IGuidEntity
    {
        public Profile()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid Guid { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
