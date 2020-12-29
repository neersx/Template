using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class UserServiceAccess
    {
        public long ServiceAccessId { get; set; }
        public int UserId { get; set; }
        public string Apikey { get; set; }
        public string Apitoken { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }

        public virtual UserMaster User { get; set; }
    }
}
