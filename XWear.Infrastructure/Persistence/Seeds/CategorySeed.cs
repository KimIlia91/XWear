using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities;

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
            new Category{ Name = CategoryEnum.Activewear.GetDescription(), CatalogId = clothing.Id, Catalog = clothing },

            new Category{ Name = CategoryEnum.Belts.GetDescription(), CatalogId = clothing.Id, Catalog = clothing },
            new Category{ Name = CategoryEnum.Bottoms.GetDescription(), CatalogId = clothing.Id, Catalog = clothing },

            new Category{ Name = CategoryEnum.Dresses.GetDescription(), CatalogId = clothing.Id, Catalog = clothing },

            new Category{ Name = CategoryEnum.FlipFlops.GetDescription(), CatalogId = shoes.Id, Catalog = shoes },

            new Category{ Name = CategoryEnum.Gloves.GetDescription(), CatalogId = accessories.Id, Catalog = accessories },
            new Category{ Name = CategoryEnum.Gumshoes.GetDescription(), CatalogId = shoes.Id, Catalog= shoes },

            new Category{ Name = CategoryEnum.Outerwear.GetDescription(), CatalogId = clothing.Id, Catalog = clothing },

            new Category{ Name = CategoryEnum.Scarves.GetDescription(), CatalogId = clothing.Id, Catalog = clothing },
            new Category{ Name = CategoryEnum.Sandals.GetDescription(), CatalogId = shoes.Id, Catalog = shoes },
            new Category{ Name = CategoryEnum.Swimwear.GetDescription(), CatalogId = clothing.Id, Catalog = clothing},
            new Category{ Name = CategoryEnum.Sunglasses.GetDescription(), CatalogId = accessories.Id, Catalog = accessories },
            new Category{ Name = CategoryEnum.Sneakers.GetDescription(), CatalogId = shoes.Id, Catalog = shoes },
            new Category{ Name = CategoryEnum.Sleepwear.GetDescription(), CatalogId = clothing.Id, Catalog = clothing },

            new Category{ Name = CategoryEnum.Handbags.GetDescription(), CatalogId = accessories.Id, Catalog = accessories },
            new Category{ Name = CategoryEnum.Hats.GetDescription(), CatalogId = accessories.Id, Catalog = accessories },

            new Category{ Name = CategoryEnum.Loafers.GetDescription(), CatalogId = shoes.Id, Catalog = shoes },
            new Category{ Name = CategoryEnum.Lingerie.GetDescription(), CatalogId = clothing.Id, Catalog = clothing },

            new Category{ Name = CategoryEnum.Ties.GetDescription(), CatalogId = clothing.Id, Catalog = clothing },
            new Category{ Name = CategoryEnum.Tops.GetDescription(), CatalogId = accessories.Id, Catalog = accessories },

            new Category{ Name = CategoryEnum.Jewelry.GetDescription(), CatalogId = accessories.Id, Catalog = accessories },

            new Category{ Name = CategoryEnum.Wallets.GetDescription(), CatalogId = accessories.Id, Catalog = accessories },
            new Category{ Name = CategoryEnum.Watches.GetDescription(), CatalogId = accessories.Id, Catalog = accessories }
        };

        return categories;
    }
}
