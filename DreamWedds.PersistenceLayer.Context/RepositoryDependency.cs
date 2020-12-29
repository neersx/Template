using DreamWedds.PersistenceLayer.Infrastructure.Repository;
using DreamWedds.PersistenceLayer.Repository.Impl;
using DreamWedds.PersistenceLayer.Repository.PersistenceServices;
using DreamWedds.PersistenceLayer.Repository.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DreamWedds.PersistenceLayer.Repository
{
    public static class RepositoryDependency
    {
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(Repository<>));
            services.AddScoped<IUserRepository, UserDataImpl>();
            services.AddScoped<IEmailRepository, EmailDataImpl>();
        }
    }
}
