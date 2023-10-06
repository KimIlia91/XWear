using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Reflection;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.WebApi.Common.Configurations.CorsConfig;
using XWear.WebApi.Common.Configurations.Localization;
using XWear.WebApi.Common.Configurations.Swagger;
using XWear.WebApi.Common.Constants;
using XWear.WebApi.Common.Errors;

namespace XWear.WebApi
{
    public static class DependepcyInjection
    {
        public static IServiceCollection AddPresentation(
           this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddHttpContextAccessor();
            services.AddAuthorization();
            services.AddControllers();
            services.AddSingleton<ProblemDetailsFactory, XWearErrorProblemDitailsFactory>();
            services.AddCorsPolicy(DomainApiConstants.CorsPolicyName, configuration);
            services.AddCustomSwaggerGen(Assembly.GetExecutingAssembly());
            services.AddCustomLocalization(LanguagesEnum.En.GetDescription(), LanguagesEnum.Ru.GetDescription());
            return services;
        }

        public static WebApplication UsePresentation(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseCustomSwaggerConfiguration();
            }

            app.UseExceptionHandler("/error");
            app.UseHttpsRedirection();
            app.MapControllers();

            app.UseCors(DomainApiConstants.CorsPolicyName);
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCustomLocalization();

            return app;
        }
    }
}
