using XWear.WebApi.Common.Configurations.Localization;
using XWear.WebApi.Common.Configurations.Swagger;
using XWear.WebApi.Common.Constants;

namespace XWear.WebApi.Common.Extensions
{
    /// <summary>
    /// Расширение для настройки кастомной конфигурации ASP.NET Core приложения.
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Применяет настройку кастомной конфигурации ASP.NET Core приложения.
        /// </summary>
        /// <param name="app">Построитель приложения (ApplicationBuilder).</param>
        /// <returns>Построитель приложения с настройками кастомной конфигурации.</returns>
        public static WebApplication UseCustomConfiguration(this WebApplication app)
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
