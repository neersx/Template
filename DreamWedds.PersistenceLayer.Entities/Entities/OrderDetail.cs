using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using DreamWedds.PersistenceLayer.Entities.Common;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class OrderDetail : BaseEntity, IAggregateRoot
    {
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? Discount { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public int TemplateId { get; set; }
        public int? SubscrptionId { get; set; }
        public OrderMaster Order { get; set; }
        public SubscriptionMaster Subscription { get; set; }
        public TemplateMaster Template { get; set; }
    }
}
