using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class GroomAndMen
    {
        public int GroomAndMenId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateofBirth { get; set; }
        public int WeddingId { get; set; }
        public bool IsGroom { get; set; }
        public int? RelationWithGroom { get; set; }
        public string Imageurl { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AboutMen { get; set; }
        public bool? IsDeleted { get; set; }
        public string FbUrl { get; set; }
        public string GoogleUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LnkedinUrl { get; set; }

        public virtual Wedding Wedding { get; set; }
    }
}
