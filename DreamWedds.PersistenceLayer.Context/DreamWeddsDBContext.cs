﻿using DreamWedds.PersistenceLayer.Entities.Common;
using DreamWedds.PersistenceLayer.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace DreamWedds.PersistenceLayer.Repository
{
    public class DreamWeddsDBContext : DbContext
    {
        public DreamWeddsDBContext(DbContextOptions<DreamWeddsDBContext> options) : base(options)
        {
        }

        public DbSet<UserMaster> UserMasters { get; set; }

        public DbSet<EmailService> EmailServices { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }

        public DbSet<CommonSetup> CommonSetup { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        //entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.IsDeleted = false;
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        //entry.Entity.ModifiedBy = _currentUserService.UserId;
                        entry.Entity.ModifiedDate = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
