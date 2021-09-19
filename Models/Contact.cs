using System;

namespace Holism.Contacts.Models
{
    public class Contact : Holism.Models.IGuidEntity
    {
        public Contact()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid Guid { get; set; }

        public Guid? UserGuid { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
