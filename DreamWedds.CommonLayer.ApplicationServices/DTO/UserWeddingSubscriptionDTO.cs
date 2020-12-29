using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DreamWedds.CommonLayer.Aspects.Utitlities;

namespace DreamWedds.CommonLayer.Application.DTO
{
    public class UserWeddingSubscriptionDTO
    {
        
        public int Id { get; set; }
        
        public int UserId { get; set; }
        
        public int TemplateID { get; set; }
        
        public int InvoiceNo { get; set; }
        
        public Nullable<int> WeddingID { get; set; }
        
        public string SubscriptionType { get; set; }
        
        public AspectEnums.SubscriptionType SubscriptionTypeList { get; set; }
        
        public string StartDate { get; set; }
        
        public string EndDate { get; set; }
        
        public string SubscriptionStatus { get; set; }
        
        public virtual TemplateMasterDTO TemplateMaster { get; set; }
        
        public virtual WeddingDTO Wedding { get; set; }
    }
}
