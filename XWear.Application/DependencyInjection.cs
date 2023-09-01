using Microsoft.Extensions.DependencyInjection;
using XWear.Application.Common.Interfaces;
using XWear.Application.Services.Authentication;

namespace XWear.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}
