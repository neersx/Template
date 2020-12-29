using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class UserSystemSettings
    {
        public long UserSystemId { get; set; }
        public int UserId { get; set; }
        public bool IsApkloggingEnabled { get; set; }
        public bool IsCoverageException { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CoverageExceptionWindow { get; set; }

        public virtual UserMaster User { get; set; }
    }
}
