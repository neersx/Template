using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class SystemSettings
    {
        public int SettingId { get; set; }
        public int CompanyId { get; set; }
        public int LogoutTime { get; set; }
        public int LoginFailedAttempt { get; set; }
        public int MaxLeaveMarkDays { get; set; }
        public string WeeklyOffDays { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public int IdleSystemDay { get; set; }

        public virtual CompanyMaster Company { get; set; }
    }
}
