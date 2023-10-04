using XWear.WebApi.Common.Configurations.Localization;
using XWear.WebApi.Common.Constants;

namespace XWear.WebApi.Common.Extensions
{
    public static class AppExtensions
    {
        public static WebApplication AddApiSettings(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "XWear v1");
                });
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
