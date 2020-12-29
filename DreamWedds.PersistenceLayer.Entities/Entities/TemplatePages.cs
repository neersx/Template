using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class TemplatePages : IAggregateRoot
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string Title { get; set; }
        public string PageContent { get; set; }
        public string PageUrl { get; set; }
        public string PageFolderPath { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public int TemplateId { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TemplateMaster Template { get; set; }
    }
}
