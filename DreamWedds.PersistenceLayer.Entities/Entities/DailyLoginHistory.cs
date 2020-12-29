using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class DailyLoginHistory
    {
        public long ID { get; set; }
        public int? UserId { get; set; }
        public int? CustomerId { get; set; }
        public string SessionId { get; set; }
        public string IpAddress { get; set; }
        public string BrowserName { get; set; }
        public int? LoginType { get; set; }
        public DateTime? LogOutTime { get; set; }
        public DateTime? LoginTime { get; set; }
        public bool IsLogin { get; set; }
        public string ApkDeviceName { get; set; }
        public string Apkversion { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }

        public UserMaster User { get; set; }
    }
}
