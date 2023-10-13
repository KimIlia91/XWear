using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace XWear.Infrastructure.Persistence
{
    public static class DependepcyInjection
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseInMemoryDatabase("DataBase"));
            
            return services;
        }
    }
}
