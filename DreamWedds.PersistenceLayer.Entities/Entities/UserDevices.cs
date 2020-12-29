using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class UserDevices
    {
        public int UserDeviceId { get; set; }
        public int UserId { get; set; }
        public string Imeinumber { get; set; }
        public string LoginName { get; set; }
        public string SenderKey { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual UserMaster User { get; set; }
    }
}
