using Microsoft.Extensions.DependencyInjection;
using PlasticGold.Services;
using PlasticGold.Services.Interfaces;
using PlasticGold.Application.Services;
using PlasticGold.Application.Services.Interfaces;
using PlasticGold.Infra.Data.Context;
using PlasticGold.Infra.Data.Repository;

namespace PlasticGold.Application.Extension
{
    public static class ApplicationExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAppManagerUserAcess, AppManagerUserAcess>();
            services.AddScoped<IManagerUserAcess, ManagerUserAcess>();

            services.AddScoped<IDbContext, DbContext>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
