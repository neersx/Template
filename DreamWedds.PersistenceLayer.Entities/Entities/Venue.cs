using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class Venue
    {
        public int VenueId { get; set; }
        public string Name { get; set; }
        public string VenueImageUrl { get; set; }
        public string VenueBannerImageUrl { get; set; }
        public string VenueWebsite { get; set; }
        public string OwnerName { get; set; }
        public string VenuePhone { get; set; }
        public string VenueMobile { get; set; }
        public int? WeddingEventId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public string GoogleMapUrl { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual WeddingEvents WeddingEvent { get; set; }
    }
}
