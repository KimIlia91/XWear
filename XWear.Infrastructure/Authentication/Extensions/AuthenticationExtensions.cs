using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using XWear.Application.Common.Interfaces.IGenerators;
using XWear.Infrastructure.Authentication.Settings;

namespace XWear.Infrastructure.Authentication.Extensions
{
    public static class AuthenticationExtensions
    {
        internal static IServiceCollection AddAuth(
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
