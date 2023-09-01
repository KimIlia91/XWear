using Microsoft.AspNetCore.Cors.Infrastructure;

namespace XWear.WebApi.Configurations.CorsConfig
{
    /// <summary>
    /// Настройки CORS
    /// </summary>
    public static class CorsSettings
    {
        /// <summary>
        /// Конфигурация CORS
        /// </summary>
        /// <param name="services"></param>
        /// <param name="corsPolicyName"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddCorsPolicy(this IServiceCollection services, string corsPolicyName,
            IConfiguration configuration)
        {
            var corsOption = configuration.GetSection("CORS").Get<CorsOptions>() ?? new CorsOptions();

            services.AddCors(options =>
            {
                options.AddPolicy(corsPolicyName,
                    builder =>
                    {
                        if (corsOption.AllowedHosts.Any())
                        {
                            builder.WithOrigins(corsOption.AllowedHosts.ToArray());
                        }
                        else
                        {
                            builder.AllowAnyOrigin();
                        }

                        if (corsOption.AllowedHeaders.Any())
                        {
                            builder
                                .WithHeaders(corsOption.AllowedHeaders.ToArray());
                        }
                        else
                        {
                            builder.AllowAnyHeader();
                        }

                        builder
                            .WithExposedHeaders("Content-Disposition")
                            .AllowAnyMethod();
                        //.AllowCredentials();
                    }
                );
            });

            return services;
        }
    }
}
