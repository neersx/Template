using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class UserRoleModulePermission
    {
        public long UserRolePermissionId { get; set; }
        public int? RoleModuleId { get; set; }
        public int? UserId { get; set; }
        public int? ModuleId { get; set; }
        public int PermissionId { get; set; }
        public string PermissionValue { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual RoleModule RoleModule { get; set; }
    }
}
