using Microsoft.EntityFrameworkCore;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities.ModelEntity;
using XWear.Domain.Entities.ProductEntity;

namespace XWear.Infrastructure.Persistence.Seeds;

public static class ProductSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!await context.Products.AnyAsync())
        {
            var products = await CreateProductsAsync(context);
            await context.Products.AddRangeAsync(products);
            await context.SaveChangesAsync();
        }
    }

    private static async Task<List<Product>> CreateProductsAsync(ApplicationDbContext context)
    {
        var products = new List<Product>();

        var categories = await context.Categories.ToListAsync();

        var activewearCloth = categories.Find(c => c.Name == CategoryEnum.Activewear.GetDescription());
        var beltsCloth = categories.Find(c => c.Name == CategoryEnum.Belts.GetDescription());
        var bottomsCloth = categories.Find(c => c.Name == CategoryEnum.Bottoms.GetDescription());
        var outerwearCloth = categories.Find(c => c.Name == CategoryEnum.Outerwear.GetDescription());
        var scarvesCloth = categories.Find(c => c.Name == CategoryEnum.Scarves.GetDescription());
        var swimwearCloth = categories.Find(c => c.Name == CategoryEnum.Swimwear.GetDescription());
        var sleepwearCloth = categories.Find(c => c.Name == CategoryEnum.Sleepwear.GetDescription());
        var lingerieCloth = categories.Find(c => c.Name == CategoryEnum.Lingerie.GetDescription());
        var tiesCloth = categories.Find(c => c.Name == CategoryEnum.Ties.GetDescription());

        var brands = await context.Brands.ToListAsync();

        var brand1 = brands.First();

        var models = await context.Models.ToListAsync();

        var tie1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Ties.GetDescription(), nameof(Model)));

        var colors = await context.Colors.ToListAsync();

        var blue = colors.Find(c => c.Value == ColorEnum.Blue);
        var red = colors.Find(c => c.Value == ColorEnum.Red);
        var green = colors.Find(c => c.Value == ColorEnum.Green);
        var black = colors.Find(c => c.Value == ColorEnum.Black);

        var sizes = await context.Sizes.ToListAsync();

        var xxl = sizes.Find(s => s.Name == "XXL");
        var xxxl = sizes.Find(s => s.Name == "XXXL");
        var m = sizes.Find(s => s.Name == "M");
        var l = sizes.Find(s => s.Name == "L");
        var s = sizes.Find(s => s.Name == "S");

        var tie1 = Product.Create(100.99m, 25, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtX3qsdbWZGNZBZN4RXdkz7ZxZ8T-tCm_1wx7hn-D0c76YtM85hE8LOrqRIFv4bnhBHfE&usqp=CAU", tiesCloth!, brand1, tie1Model!, xxl!, blue!);
        var tie2 = Product.Create(100.99m, 25, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU", tiesCloth!, brand1, tie1Model!, xxxl!, red!);
        var tie3 = Product.Create(100.99m, 25, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU", tiesCloth!, brand1, tie1Model!, m!, green!);
        var tie4 = Product.Create(100.99m, 25, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU", tiesCloth!, brand1, tie1Model!, l!, black!);
        var tie5 = Product.Create(100.99m, 25, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU", tiesCloth!, brand1, tie1Model!, s!, black!);
        products.Add(tie1.Value);
        products.Add(tie2.Value);
        products.Add(tie3.Value);
        products.Add(tie4.Value);
        products.Add(tie5.Value);

        return products;
    }
}
