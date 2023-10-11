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
        var sleepwear1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Sleepwear.GetDescription(), nameof(Model)));
        var swimwear1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Swimwear.GetDescription(), nameof(Model)));

        var colors = await context.Colors.ToListAsync();

        var blue = colors.Find(c => c.Value == ColorEnum.Blue);
        var red = colors.Find(c => c.Value == ColorEnum.Red);
        var green = colors.Find(c => c.Value == ColorEnum.Green);
        var black = colors.Find(c => c.Value == ColorEnum.Black);
        var orange = colors.Find(c => c.Value == ColorEnum.Orange);

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
        var tie5 = Product.Create(100.99m, 25, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU", tiesCloth!, brand1, tie1Model!, s!, orange!);
        products.Add(tie1.Value);
        products.Add(tie2.Value);
        products.Add(tie3.Value);
        products.Add(tie4.Value);
        products.Add(tie5.Value);

        var sleepwear1 = Product.Create(100.99m, 25, "https://assets.vogue.ru/photos/5eaadfb0166ba0cc6cf48eb8/2:3/w_2560%2Cc_limit/%25D0%25BF%25D0%25B81.jpg", sleepwearCloth!, brand1, sleepwear1Model!, xxl!, blue!);
        var sleepwear2 = Product.Create(100.99m, 25, "https://content.rozetka.com.ua/goods/images/big/330015520.jpg", sleepwearCloth!, brand1, sleepwear1Model!, xxxl!, red!);
        var sleepwear3 = Product.Create(100.99m, 25, "https://silkkiss.ua/images/detailed/12/2_3blm-98.jpg", sleepwearCloth!, brand1, sleepwear1Model!, m!, green!);
        var sleepwear4 = Product.Create(100.99m, 25, "https://images.prom.ua/3397070730_satinovaya-pizhama-victorias.jpg", sleepwearCloth!, brand1, sleepwear1Model!, l!, black!);
        var sleepwear5 = Product.Create(100.99m, 25, "https://static.insales-cdn.com/images/products/1/8156/475054044/3971945001c23ac32446baf99cb5dc3f.jpg", sleepwearCloth!, brand1, sleepwear1Model!, s!, orange!);
        products.Add(sleepwear1.Value);
        products.Add(sleepwear2.Value);
        products.Add(sleepwear3.Value);
        products.Add(sleepwear4.Value);
        products.Add(sleepwear5.Value);

        var swimwear1 = Product.Create(100.99m, 25, "https://www.mimimood.ee/catalog/thumbnails/600x800/9/7/b/a/236a6c68-d0fd-4f17-a93a-1f5f0091914d-vCiV.jpg?v1360", swimwearCloth!, brand1, swimwear1Model!, xxl!, blue!);
        var swimwear2 = Product.Create(100.99m, 25, "https://milashop.com.ua/image/cache/data/kupalniki/2304-0%20lorin-1000x1000.jpg", swimwearCloth!, brand1, swimwear1Model!, xxxl!, red!);
        var swimwear3 = Product.Create(100.99m, 25, "https://silkkiss.ua/images/detailed/12/2_3blm-98.jpg", swimwearCloth!, brand1, swimwear1Model!, m!, green!);
        var swimwear4 = Product.Create(100.99m, 25, "https://images.prom.ua/3397070730_satinovaya-pizhama-victorias.jpg", swimwearCloth!, brand1, swimwear1Model!, l!, black!);
        var swimwear5 = Product.Create(100.99m, 25, "https://www.mimimood.ee/catalog/thumbnails/600x800/9/7/b/a/236a6c68-d0fd-4f17-a93a-1f5f0091914d-vCiV.jpg?v1360", swimwearCloth!, brand1, swimwear1Model!, s!, orange!);
        products.Add(swimwear1.Value);
        products.Add(swimwear2.Value);
        products.Add(swimwear3.Value);
        products.Add(swimwear4.Value);
        products.Add(swimwear5.Value);

        return products;
    }
}
