using System;
using System.ComponentModel.DataAnnotations;

namespace DreamWedds.PersistenceLayer.Entities.Common
{
    public class BaseEntity
    {
        [Key]
        public virtual int Id { get; protected set; }
        public bool IsDeleted { get; set; } = false;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
