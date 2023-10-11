using Microsoft.EntityFrameworkCore;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities.CategoryEntity;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class CategorySeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!context.Categories.Any())
        {
            var categories = await CreateCatalogsAsync(context);
            await context.Categories.AddRangeAsync(categories);
            await context.SaveChangesAsync();
        }
    }

   public static async Task<List<Category>> CreateCatalogsAsync(ApplicationDbContext context)
   {
       var catalogs = await context.Catalogs.ToListAsync();
   
       var shoes = catalogs.First(c => c.Name == CatalogEnum.Shoes.GetDescription());
       var clothing = catalogs.First(c => c.Name == CatalogEnum.Clothing.GetDescription());
       var accessories = catalogs.First(c => c.Name == CatalogEnum.Accessories.GetDescription());
   
       var categories = new List<Category>()
       {
           Category.Create(CategoryEnum.Activewear.GetDescription(), clothing.Id).Value,
   
           Category.Create(CategoryEnum.Belts.GetDescription(), clothing.Id).Value,
           Category.Create(CategoryEnum.Bottoms.GetDescription(), clothing.Id).Value,

           Category.Create(CategoryEnum.Dresses.GetDescription(), clothing.Id).Value,

           Category.Create(CategoryEnum.FlipFlops.GetDescription(), shoes.Id).Value,

           Category.Create(CategoryEnum.Gloves.GetDescription(), accessories.Id).Value,
           Category.Create(CategoryEnum.Gumshoes.GetDescription(), shoes.Id).Value,

           Category.Create(CategoryEnum.Outerwear.GetDescription(), clothing.Id).Value,

           Category.Create(CategoryEnum.Scarves.GetDescription(), clothing.Id).Value,
           Category.Create(CategoryEnum.Sandals.GetDescription(), shoes.Id).Value,
           Category.Create(CategoryEnum.Swimwear.GetDescription(), clothing.Id).Value,
           Category.Create(CategoryEnum.Sunglasses.GetDescription(), accessories.Id).Value,
           Category.Create(CategoryEnum.Sneakers.GetDescription(), shoes.Id).Value,
           Category.Create(CategoryEnum.Sleepwear.GetDescription(), clothing.Id).Value,

           Category.Create(CategoryEnum.Handbags.GetDescription(), accessories.Id).Value,
           Category.Create(CategoryEnum.Hats.GetDescription(), accessories.Id).Value,

           Category.Create(CategoryEnum.Loafers.GetDescription(), shoes.Id).Value,
           Category.Create(CategoryEnum.Lingerie.GetDescription(), clothing.Id).Value,

           Category.Create(CategoryEnum.Ties.GetDescription(), clothing.Id).Value,
           Category.Create(CategoryEnum.Tops.GetDescription(), accessories.Id).Value,

           Category.Create(CategoryEnum.Jewelry.GetDescription(), accessories.Id).Value,

           Category.Create(CategoryEnum.Wallets.GetDescription(), accessories.Id).Value,
           Category.Create(CategoryEnum.Watches.GetDescription(), accessories.Id).Value
       };
   
       return categories;
   }
}
