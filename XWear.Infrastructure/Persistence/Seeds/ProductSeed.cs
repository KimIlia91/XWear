using Microsoft.EntityFrameworkCore;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities.ImageEntity;
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
        var scarves1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Scarves.GetDescription(), nameof(Model)));

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

        var tie1 = Product.Create(100.99m, 25, tiesCloth!, brand1, tie1Model!, xxl!, blue!);
        tie1.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtX3qsdbWZGNZBZN4RXdkz7ZxZ8T-tCm_1wx7hn-D0c76YtM85hE8LOrqRIFv4bnhBHfE&usqp=CAU");
        var tie2 = Product.Create(100.99m, 25, tiesCloth!, brand1, tie1Model!, xxxl!, red!);
        tie2.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU");
        var tie3 = Product.Create(100.99m, 25, tiesCloth!, brand1, tie1Model!, m!, green!);
        tie3.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU");
        var tie4 = Product.Create(100.99m, 25, tiesCloth!, brand1, tie1Model!, l!, black!);
        tie4.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU");
        var tie5 = Product.Create(100.99m, 25, tiesCloth!, brand1, tie1Model!, s!, orange!);
        tie5.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU");
        products.Add(tie1.Value);
        products.Add(tie2.Value);
        products.Add(tie3.Value);
        products.Add(tie4.Value);
        products.Add(tie5.Value);

        var sleepwear1 = Product.Create(100.99m, 25, sleepwearCloth!, brand1, sleepwear1Model!, xxl!, blue!);
        sleepwear1.Value.AddProductImage("https://assets.vogue.ru/photos/5eaadfb0166ba0cc6cf48eb8/2:3/w_2560%2Cc_limit/%25D0%25BF%25D0%25B81.jpg");
        var sleepwear2 = Product.Create(100.99m, 25, sleepwearCloth!, brand1, sleepwear1Model!, xxxl!, red!);
        sleepwear2.Value.AddProductImage("https://content.rozetka.com.ua/goods/images/big/330015520.jpg");
        var sleepwear3 = Product.Create(100.99m, 25, sleepwearCloth!, brand1, sleepwear1Model!, m!, green!);
        sleepwear3.Value.AddProductImage("https://silkkiss.ua/images/detailed/12/2_3blm-98.jpg");
        var sleepwear4 = Product.Create(100.99m, 25, sleepwearCloth!, brand1, sleepwear1Model!, l!, black!);
        sleepwear4.Value.AddProductImage("https://images.prom.ua/3397070730_satinovaya-pizhama-victorias.jpg");
        var sleepwear5 = Product.Create(100.99m, 25, sleepwearCloth!, brand1, sleepwear1Model!, s!, orange!);
        sleepwear5.Value.AddProductImage("https://static.insales-cdn.com/images/products/1/8156/475054044/3971945001c23ac32446baf99cb5dc3f.jpg");
        products.Add(sleepwear1.Value);
        products.Add(sleepwear2.Value);
        products.Add(sleepwear3.Value);
        products.Add(sleepwear4.Value);
        products.Add(sleepwear5.Value);

        var swimwear1 = Product.Create(100.99m, 25, swimwearCloth!, brand1, swimwear1Model!, xxl!, blue!);
        swimwear1.Value.AddProductImage("https://www.mimimood.ee/catalog/thumbnails/600x800/9/7/b/a/236a6c68-d0fd-4f17-a93a-1f5f0091914d-vCiV.jpg?v1360");
        var swimwear2 = Product.Create(100.99m, 25, swimwearCloth!, brand1, swimwear1Model!, xxxl!, red!);
        swimwear2.Value.AddProductImage("https://milashop.com.ua/image/cache/data/kupalniki/2304-0%20lorin-1000x1000.jpg");
        var swimwear3 = Product.Create(100.99m, 25, swimwearCloth!, brand1, swimwear1Model!, m!, green!);
        swimwear3.Value.AddProductImage("https://silkkiss.ua/images/detailed/12/2_3blm-98.jpg");
        var swimwear4 = Product.Create(100.99m, 25, swimwearCloth!, brand1, swimwear1Model!, l!, black!);
        swimwear4.Value.AddProductImage("https://images.prom.ua/3397070730_satinovaya-pizhama-victorias.jpg");
        var swimwear5 = Product.Create(100.99m, 25, swimwearCloth!, brand1, swimwear1Model!, s!, orange!);
        swimwear5.Value.AddProductImage("https://www.mimimood.ee/catalog/thumbnails/600x800/9/7/b/a/236a6c68-d0fd-4f17-a93a-1f5f0091914d-vCiV.jpg?v1360");
        products.Add(swimwear1.Value);
        products.Add(swimwear2.Value);
        products.Add(swimwear3.Value);
        products.Add(swimwear4.Value);
        products.Add(swimwear5.Value);

        var scarve1 = Product.Create(100.99m, 25, scarvesCloth!, brand1, scarves1Model!, xxl!, blue!);
        scarve1.Value.AddProductImage("https://renome-fashion.ru/pictures/product/big/8770_big.png");
        var scarve2 = Product.Create(100.99m, 25, scarvesCloth!, brand1, scarves1Model!, xxxl!, red!);
        scarve2.Value.AddProductImage("https://shop-cdn1-2.vigbo.tech/shops/173159/products/21021244/images/3-3262a56754684a5b228a30d8dbdf53d2.jpeg");
        var scarve3 = Product.Create(100.99m, 25, scarvesCloth!, brand1, scarves1Model!, m!, green!);
        scarve3.Value.AddProductImage("https://inspireshop.ru/upload/resize_cache/webp/upload/iblock/abb/1ajb66lq5g71a521r091szyy83yan7rv.webp");
        var scarve4 = Product.Create(100.99m, 25, scarvesCloth!, brand1, scarves1Model!, l!, black!);
        scarve4.Value.AddProductImage("https://shop-cdn1-2.vigbo.tech/shops/173159/products/21423559/images/2-19dbb21d6583cd28ac87434d9a5a8809.jpeg");
        var scarve5 = Product.Create(100.99m, 25, scarvesCloth!, brand1, scarves1Model!, s!, orange!);
        scarve5.Value.AddProductImage("https://royal-wool.ru/wp-content/uploads/2020/03/img_3314.jpg");
        products.Add(scarve1.Value);
        products.Add(scarve2.Value);
        products.Add(scarve3.Value);
        products.Add(scarve4.Value);
        products.Add(scarve5.Value);

        return products;
    }
}
