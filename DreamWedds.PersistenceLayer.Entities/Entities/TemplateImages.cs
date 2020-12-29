using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class TemplateImages : IAggregateRoot
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string ImageTitle { get; set; }
        public string ImageTagLine { get; set; }
        public string ImageUrl { get; set; }
        public string ImageFolderPath { get; set; }
        public bool IsBannerImage { get; set; }
        public int TemplateId { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ImageType { get; set; }

        public TemplateMaster Template { get; set; }
    }
}
