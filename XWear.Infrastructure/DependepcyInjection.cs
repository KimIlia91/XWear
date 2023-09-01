﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XWear.Application.Common.Interfaces;
using XWear.Infrastructure.Authentication;
using XWear.Infrastructure.Authentication.Settings;
using XWear.Infrastructure.Persistence;

namespace XWear.Infrastructure
{
    public static class DependepcyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(nameof(JwtSettings)));

            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
