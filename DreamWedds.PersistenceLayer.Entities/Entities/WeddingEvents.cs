using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class WeddingEvents
    {
        public WeddingEvents()
        {
            Venue = new HashSet<Venue>();
        }

        public int WeddingEventId { get; set; }
        public DateTime EventDate { get; set; }
        public string Title { get; set; }
        public int WeddingId { get; set; }
        public string ImageUrl { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Aboutevent { get; set; }
        public string BackGroundImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Wedding Wedding { get; set; }
        public virtual ICollection<Venue> Venue { get; set; }
    }
}
