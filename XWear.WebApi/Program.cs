using Microsoft.AspNetCore.Mvc.Infrastructure;
using XWear.Application;
using XWear.Infrastructure;
using XWear.WebApi.Common.Errors;

namespace XWear.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services
                .AddApplication()
                .AddInfrastructure(builder.Configuration);

            builder.Services.AddAuthorization();
            builder.Services.AddControllers();
            builder.Services.AddSingleton<ProblemDetailsFactory, XWearErrorProblemDitailsFactory>();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseExceptionHandler("/error");
            app.MapControllers();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.Run();
        }
    }
}