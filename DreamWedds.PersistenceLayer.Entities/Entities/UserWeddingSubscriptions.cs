using System;
using System.Collections.Generic;
using DreamWedds.PersistenceLayer.Entities.Common;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class UserWeddingSubscriptions : BaseEntity, IAggregateRoot
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TemplateId { get; set; }
        public int? OrderNo { get; set; }
        public int? WeddingId { get; set; }
        public int SubscriptionType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string ReasonOfUpdate { get; set; }
        public int SubscriptionStatus { get; set; }

        public virtual OrderMaster OrderMaster { get; set; }
        public virtual SubscriptionMaster SubscriptionMaster { get; set; }
        public virtual TemplateMaster Template { get; set; }
        public virtual Wedding Wedding { get; set; }
    }
}
