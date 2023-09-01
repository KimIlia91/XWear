using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;

namespace XWear.WebApi.Configurations.Localization
{
    public static class LocalizationSettings
    {
        public static IServiceCollection AddCustomLocalization(this IServiceCollection services, string defaultCulture,
           params string[] supportedCultures)
        {
            services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultureInfos = supportedCultures.Select(x => new CultureInfo(x)).ToList();

                options.DefaultRequestCulture = new RequestCulture(defaultCulture);
                options.SupportedCultures = supportedCultureInfos;
                options.SupportedUICultures = supportedCultureInfos;
            });

            return services;
        }

        public static IApplicationBuilder UseCustomLocalization(this IApplicationBuilder app)
        {
            var requestLocalizationOptions =
                app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>()?.Value;

            if (requestLocalizationOptions != null)
            {
                app.UseRequestLocalization(requestLocalizationOptions);
            }

            return app;
        }
    }
}
