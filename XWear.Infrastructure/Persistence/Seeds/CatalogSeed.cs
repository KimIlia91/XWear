using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities.CatalogEntity;

namespace XWear.Infrastructure.Persistence.Seeds;

internal static class CatalogSeed
{
    internal static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!context.Catalogs.Any())
        {
            var catalogs = CreateCatalogs();
            await context.Catalogs.AddRangeAsync(catalogs);
            await context.SaveChangesAsync();
        }
    }

   private static List<Catalog> CreateCatalogs()
   {
       var catalogs = new List<Catalog>()
       {
           Catalog.Create(CatalogEnum.Accessories.GetDescription()).Value,
           Catalog.Create(CatalogEnum.Clothing.GetDescription()).Value,
           Catalog.Create(CatalogEnum.Shoes.GetDescription()).Value
       };
   
       return catalogs;
   }
}
