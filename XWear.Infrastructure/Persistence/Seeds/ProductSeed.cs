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
