using System;
using System.Collections.Generic;
using DreamWedds.PersistenceLayer.Entities.Common;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class DreamWeddsBlog : BaseEntity, IAggregateRoot
    {
        public int Id { get; set; }
        public string BlogName { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Quote { get; set; }
        public string AuthorName { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string SpecialNote { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
