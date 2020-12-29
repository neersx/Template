using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DreamWedds.CommonLayer.Application.DTO;

namespace DreamWedds.CommonLayer.Application.DTO
{
    public class OrderMasterDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string OrderDate { get; set; }
        [DataMember]
        public string RequiredDate { get; set; }
        [DataMember]
        public string OrderStatus { get; set; }
        [DataMember]
        public string AddressID { get; set; }
        [DataMember]
        public int? CGST { get; set; }
        [DataMember]
        public int? SGST { get; set; }
        [DataMember]
        public int? Discount { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public decimal ReceivedAmount { get; set; }
        [DataMember]
        public int PaymentMode { get; set; }
        [DataMember]
        public string PaymentTerms { get; set; }
        [DataMember]
        public string OderNote { get; set; }
        [DataMember]
        public bool IsDeleted { get; set; }
        [DataMember]
        public virtual ICollection<OrderDetailDTO> OrderDetails { get; set; }
        [DataMember]
        public virtual ICollection<UserWeddingSubscriptionDTO> UserWeddingSubscriptions { get; set; }

    }

    public class OrderDetailDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> Discount { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public int TemplateID { get; set; }
        [DataMember]
        public bool IsDeleted { get; set; }
        [DataMember]
        public Nullable<int> SubscrptionID { get; set; }

        // public virtual OrderMasterBO OrderMaster { get; set; }
        //public virtual SubscriptionMasterBO SubscriptionMaster { get; set; }
        [DataMember]
        public virtual TemplateMasterDTO TemplateMaster { get; set; }
    }
}
