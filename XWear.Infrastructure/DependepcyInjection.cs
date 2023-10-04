using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using XWear.Application.Common.Interfaces;
using XWear.Infrastructure.Authentication;
using XWear.Infrastructure.Authentication.Settings;
using XWear.Infrastructure.Persistence;
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
            services.AddScoped<ICurrentUserService, CurrentUserService>();

            return services;
        }

        private static IServiceCollection AddAuth(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var jwtSettings = new JwtSettings();
            configuration.Bind(nameof(JwtSettings), jwtSettings);
            services.AddSingleton(Options.Create(jwtSettings));

            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services
                .AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
                {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = jwtSettings.Issuer,
                   ValidAudience = jwtSettings.Audience,
                   IssuerSigningKey = new SymmetricSecurityKey(
                       Encoding.UTF8.GetBytes(jwtSettings.Secret))
                });

            return services;
        }
    }
}
