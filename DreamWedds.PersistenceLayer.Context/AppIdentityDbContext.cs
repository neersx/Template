using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using DreamWedds.BusinessLayer.Services;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.ApplicationServices;
using DreamWedds.PersistenceLayer.Entities.Common;
using DreamWedds.PersistenceLayer.Entities.Entities;
using DreamWedds.PersistenceLayer.Entities.Identity;
using IdentityModel;
using IdentityServer4.EntityFramework.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DreamWedds.PersistenceLayer.Repository
{
    public class AppIdentityDbContext
    {
        //private readonly ICurrentUserService _currentUserService;
        //private readonly IDateTime _dateTime;

        //public AppIdentityDbContext(ICurrentUserService currentUserService, IDateTime dateTime, DbContextOptions<AppIdentityDbContext> options)
        //  : base(options)
        //{
        //    _currentUserService = currentUserService;
        //    _dateTime = dateTime;
        //}

    }
}
