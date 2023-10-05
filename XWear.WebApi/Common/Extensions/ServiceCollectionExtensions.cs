﻿using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Reflection;
using XWear.Application;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Infrastructure;
using XWear.WebApi.Common.Configurations.CorsConfig;
using XWear.WebApi.Common.Configurations.Localization;
using XWear.WebApi.Common.Configurations.Swagger;
using XWear.WebApi.Common.Constants;
using XWear.WebApi.Common.Errors;

namespace XWear.WebApi.Common.Extensions
{
    /// <summary>
    /// Расширение для добавления кастомных служб в контейнер служб ASP.NET Core.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Добавляет кастомные службы в контейнер служб ASP.NET Core.
        /// </summary>
        /// <param name="services">Контейнер служб (IServiceCollection).</param>
        /// <param name="configuration">Конфигурация приложения.</param>
        /// <returns>Контейнер служб с добавленными кастомными службами.</returns>
        public static IServiceCollection AddPresintation(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddHttpContextAccessor();
            services.AddAuthorization();
            services.AddControllers();
            services.AddSingleton<ProblemDetailsFactory, XWearErrorProblemDitailsFactory>();
            services.AddCorsPolicy(DomainApiConstants.CorsPolicyName, configuration);
            services.AddCustomSwaggerGen("v1", Assembly.GetExecutingAssembly());
            services.AddCustomLocalization(LanguagesEnum.En.GetDescription(), LanguagesEnum.Ru.GetDescription());
            return services;
        }
    }
}
