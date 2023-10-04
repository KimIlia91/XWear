using XWear.WebApi.Common.Constants;
using XWear.WebApi.Configurations.Localization;

namespace XWear.WebApi
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
