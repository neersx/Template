using System;
using System.Collections.Generic;
using DreamWedds.PersistenceLayer.Entities.Common;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class TemplateMaster : BaseEntity,IAggregateRoot
    {
        public TemplateMaster()
        {
            //OrderDetails = new HashSet<OrderDetail>();
            TemplateImages = new HashSet<TemplateImages>();
            //TemplateMergeFields = new HashSet<TemplateMergeFields>();
            //TemplatePages = new HashSet<TemplatePages>();
            //UserWeddingSubscriptions = new HashSet<UserWeddingSubscriptions>();
        }
        public string TemplateName { get; set; }
        public int TemplateType { get; set; }
        public int TemplateStatus { get; set; }
        public string TemplateContent { get; set; }
        public string TemplateSubject { get; set; }
        public string TemplateTags { get; set; }
        public string TemplateUrl { get; set; }
        public string TemplateFolderPath { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public string TagLine { get; set; }
        public int? Cost { get; set; }
        public string AuthorName { get; set; }
        public string AboutTemplate { get; set; }
        public string Features { get; set; }
        public int? TemplateCode { get; set; }

        //public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<TemplateImages> TemplateImages { get; set; }
        //public ICollection<TemplateMergeFields> TemplateMergeFields { get; set; }
        //public ICollection<TemplatePages> TemplatePages { get; set; }
        //public ICollection<UserWeddingSubscriptions> UserWeddingSubscriptions { get; set; }
    }
}
