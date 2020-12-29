using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class AddressMaster
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Country { get; set; }
        public int PinCode { get; set; }
        public int? AddressType { get; set; }
        public int? AddressStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int? UserId { get; set; }
        public int? AddressOwnerType { get; set; }
        public int? AddressOwnerTypePkid { get; set; }
        public int? VenueId { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }
    }
}
