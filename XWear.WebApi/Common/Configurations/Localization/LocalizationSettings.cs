using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;
using XWear.WebApi.Common.Constants;

namespace XWear.WebApi.Configurations.Localization
{
    /// <summary>
    /// Локализация расширение
    /// </summary>
    public static class LocalizationSettings
    {
        /// <summary>
        /// Добавление локализации метод расширения
        /// </summary>
        /// <param name="services">Интерфейс сервсиа</param>
        /// <param name="defaultCulture">Язык по умолчанию</param>
        /// <param name="supportedCultures">Список поддерживаемых языков</param>
        /// <returns></returns>
        public static IServiceCollection AddCustomLocalization(this IServiceCollection services, string defaultCulture,
           params string[] supportedCultures)
        {
            services.AddLocalization(opt => { opt.ResourcesPath = DomainApiConstants.ResourcesPath; });

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultureInfos = supportedCultures.Select(x => new CultureInfo(x)).ToList();

                options.DefaultRequestCulture = new RequestCulture(defaultCulture);
                options.SupportedCultures = supportedCultureInfos;
                options.SupportedUICultures = supportedCultureInfos;
            });

            return services;
        }

        /// <summary>
        /// Подключить использование локализации
        /// </summary>
        /// <param name="app">Билдер интерфейс</param>
        /// <returns></returns>
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
