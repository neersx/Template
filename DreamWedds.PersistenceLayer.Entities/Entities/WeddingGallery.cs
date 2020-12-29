using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class WeddingGallery
    {
        public int WeddingGalleryId { get; set; }
        public string ImageTitle { get; set; }
        public int WeddingId { get; set; }
        public string ImageUrl { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string ImageName { get; set; }
        public DateTime? DateTaken { get; set; }
        public string Place { get; set; }

        public virtual Wedding Wedding { get; set; }
    }
}
