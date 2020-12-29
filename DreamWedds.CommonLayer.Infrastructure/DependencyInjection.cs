using DreamWedds.BusinessLayer.ServiceManager;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.CommonLayer.ApplicationServices;
using DreamWedds.CommonLayer.ApplicationServices.Impl;
using DreamWedds.CommonLayer.Aspects.Constants;
using DreamWedds.CommonLayer.Infrastructure.Impl;
using DreamWedds.PersistenceLayer.Entities.Entities;
using DreamWedds.PersistenceLayer.Entities.Identity;
using DreamWedds.PersistenceLayer.Infrastructure;
using DreamWedds.PersistenceLayer.Infrastructure.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using DreamWedds.PersistenceLayer.Repository;
using DreamWedds.PersistenceLayer.Repository.Repository;

namespace DreamWedds.CommonLayer.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<AppIdentityDbContext>(c =>
            //    c.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<DreamWeddsDBContext>(c =>
                c.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(Repository<>));
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IUserService, UserServiceManager>();
            services.AddRepositoryDependency();
            services.AddScoped<ITokenClaimsService, IdentityTokenClaimService>();

            services.AddTransient<ITemplateService, TemplateServiceManager>();
            services.AddTransient<IBlogService, BlogServiceManager>();
            services.AddTransient<IEmailService, EmailServiceManager>();
            
            //services.AddAuthentication()
            //    .AddIdentityServerJwt();

            //services.AddMemoryCache();
            //// https://stackoverflow.com/questions/46938248/asp-net-core-2-0-combining-cookies-and-bearer-authorization-for-the-same-endpoin
            //var key = Encoding.ASCII.GetBytes(AuthorizationConstants.JWT_SECRET_KEY);
            //services.AddAuthentication(config =>
            //{
            //    config.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
            //    config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //    config.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(x =>
            //{
            //    x.RequireHttpsMetadata = false;
            //    x.SaveToken = true;
            //    x.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(key),
            //        ValidateIssuer = false,
            //        ValidateAudience = false
            //    };
            //});

            return services;
        }
    }
}
