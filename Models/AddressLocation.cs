namespace Holism.Contacts.Models
{
    public class AddressLocation : Holism.Models.IEntity
    {
        public AddressLocation()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Location { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
