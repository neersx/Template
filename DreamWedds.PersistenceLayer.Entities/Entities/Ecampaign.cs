using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class ECampaign : IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string LogoUrl { get; set; }
        public int TemplateId { get; set; }
        public string Content { get; set; }
        public int? Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int? CategoryId { get; set; }
    }
}
