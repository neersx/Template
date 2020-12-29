using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class TemplateMergeFields : IAggregateRoot
    {
        public int Id { get; set; }
        public string MergefieldName { get; set; }
        public string SrcField { get; set; }
        public string SrcFieldValue { get; set; }
        public bool IsDeleted { get; set; }
        public int? TemplateId { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? Sequence { get; set; }
        public int? TemplateCode { get; set; }

        public virtual TemplateMaster Template { get; set; }
    }
}
