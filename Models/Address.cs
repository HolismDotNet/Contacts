using System;

namespace Holism.Contacts.Models
{
    public class Address : Holism.Models.IGuidEntity
    {
        public Address()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid Guid { get; set; }

        public long ContactId { get; set; }

        public Guid CountryGuid { get; set; }

        public Guid? ProvinceOrStateGuid { get; set; }

        public Guid CityGuid { get; set; }

        public string Rest { get; set; }

        public string Remarks { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
