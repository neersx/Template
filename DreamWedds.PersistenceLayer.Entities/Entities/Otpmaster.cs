using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class Otpmaster
    {
        public long OtpmasterId { get; set; }
        public int UserId { get; set; }
        public string Otp { get; set; }
        public string Guid { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? Attempts { get; set; }
    }
}
