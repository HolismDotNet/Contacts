using System;

namespace Holism.Contacts.Models
{
    public class Phone : Holism.Models.IGuidEntity
    {
        public Phone()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid Guid { get; set; }

        public long ContactId { get; set; }

        public Guid CountryGuid { get; set; }

        public string PhoneValue { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
