using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class BrideAndMaid
    {
        public int BrideAndMaidId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateofBirth { get; set; }
        public int WeddingId { get; set; }
        public bool IsBride { get; set; }
        public int? RelationWithBride { get; set; }
        public string Imageurl { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public string AboutBrideMaid { get; set; }
        public bool? IsDeleted { get; set; }
        public string FbUrl { get; set; }
        public string GoogleUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LnkedinUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Wedding Wedding { get; set; }
    }
}
