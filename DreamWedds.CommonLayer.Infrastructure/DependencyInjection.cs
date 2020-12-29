﻿using DreamWedds.BusinessLayer.ServiceManager;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.CommonLayer.ApplicationServices;
using DreamWedds.CommonLayer.ApplicationServices.Impl;
using DreamWedds.CommonLayer.Infrastructure.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DreamWedds.PersistenceLayer.Repository;
using DreamWedds.PersistenceLayer.Repository.Repository;

namespace DreamWedds.CommonLayer.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdminDbContext>(c =>
                c.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(Repository<>));
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IUserService, UserServiceManager>();
            services.AddRepositoryDependency();
            services.AddScoped<ITokenClaimsService, IdentityTokenClaimService>();

            services.AddTransient<IEmailService, EmailServiceManager>();
           
            return services;
        }
    }
}
