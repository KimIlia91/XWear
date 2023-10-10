using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class CatalogSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        //if (!context.Catalogs.Any())
        //{
        //    var catalogs = CreateCatalogs();
        //    await context.Catalogs.AddRangeAsync(catalogs);
        //    await context.SaveChangesAsync();
        //}
    }

   //private static List<Catalog> CreateCatalogs()
   //{
   //    var catalogs = new List<Catalog>()
   //    {
   //        new Catalog{ Name = CatalogEnum.Accessories.GetDescription() },
   //        new Catalog{ Name = CatalogEnum.Clothing.GetDescription() },
   //        new Catalog{ Name = CatalogEnum.Shoes.GetDescription() }
   //    };
   //
   //    return catalogs;
   //}
}
