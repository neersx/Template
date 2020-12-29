using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class TimeLine
    {
        public int TimeLineId { get; set; }
        public DateTime StoryDate { get; set; }
        public string Title { get; set; }
        public string Story { get; set; }
        public string ImageUrl { get; set; }
        public int WeddingId { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Location { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Wedding Wedding { get; set; }
    }
}
