using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Infrastructure.Authentication.Extensions;
using XWear.Infrastructure.Persistence.Repositories;
using XWear.Infrastructure.Services;

namespace XWear.Infrastructure
{
    public static class DependepcyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddAuth(configuration);
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();

            return services;
        }
    }
}
