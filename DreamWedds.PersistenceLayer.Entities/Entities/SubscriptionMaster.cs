using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class SubscriptionMaster : IAggregateRoot
    {
        public SubscriptionMaster()
        {
            OrderDetail = new HashSet<OrderDetail>();
            UserWeddingSubscriptions = new HashSet<UserWeddingSubscriptions>();
        }

        public int Id { get; set; }
        public int SubsType { get; set; }
        public string SubsName { get; set; }
        public string SubsCode { get; set; }
        public int Days { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<UserWeddingSubscriptions> UserWeddingSubscriptions { get; set; }
    }
}
