using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using DreamWedds.PersistenceLayer.Entities.Common;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class OrderMaster : BaseEntity,IAggregateRoot
    {
        public OrderMaster()
        {
            OrderDetail = new HashSet<OrderDetail>();
            UserWeddingSubscriptions = new HashSet<UserWeddingSubscriptions>();
        }

        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string OrderStatus { get; set; }
        public string AddressId { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal Gst { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public int? Discount { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? ReceivedAmount { get; set; }
        public int PaymentMode { get; set; }
        public string PaymentTerms { get; set; }
        public string OrderNote { get; set; }

        public virtual UserMaster User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<UserWeddingSubscriptions> UserWeddingSubscriptions { get; set; }
    }
}
