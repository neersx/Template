﻿using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class LoginAttemptHistory
    {
        public long LoginAttemptId { get; set; }
        public int? FailedAttempt { get; set; }
        public int UserId { get; set; }
        public DateTime? LoginDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }
        public string IpAddress { get; set; }
        public string Browser { get; set; }

        public virtual UserMaster User { get; set; }
    }
}