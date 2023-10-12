using Microsoft.Extensions.DependencyInjection;
using XWear.Infrastructure.Persistence.Seeds;
using XWear.Infrastructure.Persistence.Seedsl;

namespace XWear.Infrastructure.Persistence
{
    public static class DataBaseSeeds
    {
        public static async Task AddSeeds(IServiceProvider services)
        {
            var context = services.GetRequiredService<ApplicationDbContext>();
            
            await BrandSeed.SeedAsync(context);
            await CatalogSeed.SeedAsync(context);
            await CategorySeed.SeedAsync(context);
            await ColorSeed.SeedAsync(context);
            await ModelSeed.SeedAsync(context);
            await SizeSeed.SeedAsync(context);
            await ProductSeed.SeedAsync(context);
            await UserSeed.SeedAsync(context);
        }
    }
}
