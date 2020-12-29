using System.Text;
using System.Threading.Tasks;
using DreamWedds.BusinessLayer.Services;
using DreamWedds.CommonLayer.Application;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.CommonLayer.Aspects.Helpers;
using DreamWedds.CommonLayer.Infrastructure;
using DreamWedds.PersistenceLayer.Entities.Entities;
using DreamWedds.PersistenceLayer.Entities.Identity;
using DreamWedds.PersistenceLayer.Infrastructure;
using DreamWedds.PersistenceLayer.Repository;
using DreamWedds.PresentationLayer.WebApi.CustomFilters;
using DreamWedds.PresentationLayer.WebApi.Helpers;
using DreamWedds.PresentationLayer.WebApi.Model;
using DreamWedds.PresentationLayer.WebApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace DreamWedds.PresentationLayer.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Add Application  CORS  
            services.AddCors(options => options.AddPolicy("Cors", builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));
            #endregion

            services.Configure<Encryption>(Configuration.GetSection(nameof(Encryption)));
            services.AddSingleton(resolver => resolver.GetRequiredService<IOptionsMonitor<Encryption>>().CurrentValue);
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = context =>
                        {
                            var userService = context.HttpContext.RequestServices.GetRequiredService<IUserService>();
                            var isAuthenticated = context.Principal.Identity.IsAuthenticated;
                            //var user = userService.GetUserAsync(userId);
                            if (!isAuthenticated)
                            {
                                // return unauthorized if user no longer exists
                                context.Fail("Unauthorized");
                            }
                            return Task.CompletedTask;
                        }
                    };
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddApplication();
            
            //services.AddScoped<SignInManager<ApplicationUser>, SignInManager<ApplicationUser>>();
            //services.AddDefaultIdentity<ApplicationUser>(
            //        options => options.SignIn.RequireConfirmedAccount = false)
            //    //.AddRoles<ApplicationRole>()
            //    .AddEntityFrameworkStores<AppIdentityDbContext>();
            services.AddInfrastructure(Configuration);
            services.AddHttpContextAccessor();

            services.AddControllersWithViews(options =>
                options.Filters.Add(new ApiExceptionFilter()));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(x => x
             .AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader());
            app.UseMiddleware<JwtMiddleware>();
            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

