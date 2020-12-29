using DreamWedds.PersistenceLayer.Entities.Common;
using DreamWedds.PersistenceLayer.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using DreamWedds.CommonLayer.Aspects.Extensions;
using Microsoft.AspNetCore.Http;

namespace DreamWedds.PersistenceLayer.Repository
{
    public class AdminDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AdminDbContext(DbContextOptions<AdminDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<AddressMaster> AddressMaster { get; set; }
        public DbSet<UserMaster> UserMasters { get; set; }
        public DbSet<RoleMaster> RoleMasters { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<DailyLoginHistory> DailyLoginHistory { get; set; }
        public DbSet<LoginAttemptHistory> LoginAttemptHistory { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<UserRoleModulePermission> UserRoleModulePermission { get; set; }
        public DbSet<SystemSettings> SystemSettings { get; set; }
        public DbSet<EmailService> EmailServices { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<OtpMaster> OtpMaster { get; set; }
        public DbSet<ErrorLog> ErrorLog { get; set; }
        public DbSet<ModuleMaster> ModuleMasters { get; set; }
        public DbSet<CompanyMaster> CompanyMaster { get; set; }
        public DbSet<RoleModule> RoleModule { get; set; }
        public DbSet<CommonSetup> CommonSetup { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _httpContextAccessor.HttpContext.User.GetLoggedInUserId<int>();
                        entry.Entity.IsDeleted = false;
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = _httpContextAccessor.HttpContext.User.GetLoggedInUserId<int>();
                        entry.Entity.ModifiedDate = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
