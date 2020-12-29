
using DreamWedds.PersistenceLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class UserMaster : BaseEntity, IAggregateRoot
    {
            public UserMaster()
            {
                this.DailyLoginHistory = new HashSet<DailyLoginHistory>();
                //this.LoginAttemptHistories = new HashSet<LoginAttemptHistory>();
                //this.OrderMasters = new HashSet<OrderMaster>();
                //this.UserDevices = new HashSet<UserDevice>();
                this.UserRoles = new HashSet<UserRoles>();
                //this.UserServiceAccesses = new HashSet<UserServiceAccess>();
                //this.UserSystemSettings = new HashSet<UserSystemSetting>();
            }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string EmpCode { get; set; }
        public string Email { get; set; }
        public int? AccountStatus { get; set; }
        public bool? IsActive { get; set; }
        public int? SeniorEmpId { get; set; }
        public bool? IsEmployee { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public int CompanyId { get; set; }
        public CompanyMaster Company { get; set; }
        public virtual ICollection<DailyLoginHistory> DailyLoginHistory { get; set; }
        //public virtual ICollection<LoginAttemptHistory> LoginAttemptHistory { get; set; }
        //public virtual ICollection<OrderMaster> OrderMaster { get; set; }
        //public virtual ICollection<UserDevices> UserDevices { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        //public virtual ICollection<UserServiceAccess> UserServiceAccess { get; set; }
        //public virtual ICollection<UserSystemSettings> UserSystemSettings { get; set; }
    }
}
