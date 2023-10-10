using XWear.Domain.Entities;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using Microsoft.EntityFrameworkCore;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class ProductSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        //if (!await context.Products.AnyAsync())
        //{
        //    var products = await CreateProductsAsync(context);
        //    await context.Products.AddRangeAsync(products);
        //    await context.SaveChangesAsync();
        //}
    }
}
