using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class VwGetUserWeddingTemplates
    {
        public int UserId { get; set; }
        public int? AccountStatus { get; set; }
        public int OrderId { get; set; }
        public int? WeddingId { get; set; }
        public int TemplateId { get; set; }
        public DateTime OrderDate { get; set; }
        public int? UserWeddingSubscrptionId { get; set; }
        public decimal Amount { get; set; }
        public string OrderStatus { get; set; }
        public int? PaymentMode { get; set; }
        public int? Discount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? SubscriptionType { get; set; }
        public int? SubscriptionStatus { get; set; }
        public string TemplateName { get; set; }
        public string TemplateFolderPath { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public DateTime? WeddingDate { get; set; }
        public string Title { get; set; }
        public string BackgroundImage { get; set; }
    }
}
