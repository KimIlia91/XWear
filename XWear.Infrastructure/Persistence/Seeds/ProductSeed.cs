using Microsoft.EntityFrameworkCore;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using XWear.Domain.Entities.ImageEntity;
using XWear.Domain.Entities.ModelEntity;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.ProductSizeEntity;
using XWear.Domain.Entities.SizeEntity;

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

        //Одежда
        var activewearCloth = categories.Find(c => c.Name == CategoryEnum.Activewear.GetDescription());
        var beltsCloth = categories.Find(c => c.Name == CategoryEnum.Belts.GetDescription());
        var bottomsCloth = categories.Find(c => c.Name == CategoryEnum.Bottoms.GetDescription());
        var outerwearCloth = categories.Find(c => c.Name == CategoryEnum.Outerwear.GetDescription());
        var scarvesCloth = categories.Find(c => c.Name == CategoryEnum.Scarves.GetDescription());
        var swimwearCloth = categories.Find(c => c.Name == CategoryEnum.Swimwear.GetDescription());
        var sleepwearCloth = categories.Find(c => c.Name == CategoryEnum.Sleepwear.GetDescription());
        var tiesCloth = categories.Find(c => c.Name == CategoryEnum.Ties.GetDescription());
        var dressesCloth = categories.Find(c => c.Name == CategoryEnum.Dresses.GetDescription());

        //Обувь
        var shoesShoes = categories.Find(c => c.Name == CategoryEnum.Shoes.GetDescription());
        var loafersShoes = categories.Find(c => c.Name == CategoryEnum.Loafers.GetDescription());
        var sneakersShoes = categories.Find(c => c.Name == CategoryEnum.Sneakers.GetDescription());
        var flipFlopsShoes = categories.Find(c => c.Name == CategoryEnum.FlipFlops.GetDescription());
        var sandalsShoes = categories.Find(c => c.Name == CategoryEnum.Sandals.GetDescription());
        var gumshoesShoes = categories.Find(c => c.Name == CategoryEnum.Gumshoes.GetDescription());

        //Аксессуары
        var watchesCategory = categories.Find(c => c.Name == CategoryEnum.Watches.GetDescription());
        var walletsCategory = categories.Find(c => c.Name == CategoryEnum.Wallets.GetDescription());
        var jewelryCategory = categories.Find(c => c.Name == CategoryEnum.Jewelry.GetDescription());
        var glovesCategory = categories.Find(c => c.Name == CategoryEnum.Gloves.GetDescription());
        var sunglassesCategory = categories.Find(c => c.Name == CategoryEnum.Sunglasses.GetDescription());
        var handbagsCategory = categories.Find(c => c.Name == CategoryEnum.Handbags.GetDescription());
        var hatsCategory = categories.Find(c => c.Name == CategoryEnum.Hats.GetDescription());

        var brands = await context.Brands.ToListAsync();

        var brand1 = brands.First();

        var models = await context.Models.ToListAsync();

        //Одежда модели
        var tie1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Ties.GetDescription(), nameof(Model)));
        var sleepwear1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Sleepwear.GetDescription(), nameof(Model)));
        var swimwear1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Swimwear.GetDescription(), nameof(Model)));
        var scarves1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Scarves.GetDescription(), nameof(Model)));
        var outwear1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Outerwear.GetDescription(), nameof(Model)));
        var bottoms1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Bottoms.GetDescription(), nameof(Model)));
        var belts1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Belts.GetDescription(), nameof(Model)));
        var activewear1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Activewear.GetDescription(), nameof(Model)));
        var dresses1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Dresses.GetDescription(), nameof(Model)));

        //Обувь модели
        var shoes1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Shoes.GetDescription(), nameof(Model)));
        var loafers1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Loafers.GetDescription(), nameof(Model)));
        var sneakers1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Sneakers.GetDescription(), nameof(Model)));
        var flipFlops1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.FlipFlops.GetDescription(), nameof(Model)));
        var sandals1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Sandals.GetDescription(), nameof(Model)));
        var gumshoes1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Gumshoes.GetDescription(), nameof(Model)));

        //Аксессуары модели
        var wallets1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Wallets.GetDescription(), nameof(Model)));
        var watches1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Watches.GetDescription(), nameof(Model)));
        var jewelry1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Jewelry.GetDescription(), nameof(Model)));
        var gloves1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Gloves.GetDescription(), nameof(Model)));
        var sunglasses1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Sunglasses.GetDescription(), nameof(Model)));
        var handbags1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Handbags.GetDescription(), nameof(Model)));
        var hats1Model = models.Find(m => m.Name == string.Join(" ", CategoryEnum.Hats.GetDescription(), nameof(Model)));

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
        var thirtyEight = sizes.Find(s => s.Name == SizeEnum.ThirtyEight.GetDescription());
        var thirtyNine = sizes.Find(s => s.Name == SizeEnum.ThirtyNine.GetDescription());
        var forty = sizes.Find(s => s.Name == SizeEnum.Forty.GetDescription());
        var fortyOne = sizes.Find(s => s.Name == SizeEnum.FortyOne.GetDescription());
        var fortyTwo = sizes.Find(s => s.Name == SizeEnum.FortyTwo.GetDescription());
        var fortyThree = sizes.Find(s => s.Name == SizeEnum.FortyThree.GetDescription());
        var fortyFour = sizes.Find(s => s.Name == SizeEnum.FortyFour.GetDescription());
        var fortyFive = sizes.Find(s => s.Name == SizeEnum.FortyFive.GetDescription());

        var clorhSizes = new List<Size>() { xxl, xxxl, m, l, s };
        var shoesSizes = new List<Size>() { thirtyEight, thirtyNine, forty, fortyOne, fortyTwo, fortyThree, fortyFour, fortyFive };

        //Одежда
        var tie1 = Product.Create(tiesCloth!, brand1, tie1Model!, blue!);
        tie1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        tie1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        tie1.Value.AddProductSize(l.Id, 100.99m, 25);
        tie1.Value.AddProductSize(m.Id, 100.99m, 25);
        tie1.Value.AddProductSize(s.Id, 100.99m, 25);

        tie1.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtX3qsdbWZGNZBZN4RXdkz7ZxZ8T-tCm_1wx7hn-D0c76YtM85hE8LOrqRIFv4bnhBHfE&usqp=CAU");

        var tie2 = Product.Create(tiesCloth!, brand1, tie1Model!, red!);
        tie2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        tie2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        tie2.Value.AddProductSize(l.Id, 100.99m, 25);
        tie2.Value.AddProductSize(m.Id, 100.99m, 25);
        tie2.Value.AddProductSize(s.Id, 100.99m, 25);

        tie2.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU");
        
        var tie3 = Product.Create(tiesCloth!, brand1, tie1Model!, green!);
        tie3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        tie3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        tie3.Value.AddProductSize(l.Id, 100.99m, 25);
        tie3.Value.AddProductSize(m.Id, 100.99m, 25);
        tie3.Value.AddProductSize(s.Id, 100.99m, 25);

        tie3.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU");

        var tie4 = Product.Create(tiesCloth!, brand1, tie1Model!, black!);
        tie4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        tie4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        tie4.Value.AddProductSize(l.Id, 100.99m, 25);
        tie4.Value.AddProductSize(m.Id, 100.99m, 25);
        tie4.Value.AddProductSize(s.Id, 100.99m, 25);

        tie4.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU");

        var tie5 = Product.Create(tiesCloth!, brand1, tie1Model!, orange!);
        tie5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        tie5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        tie5.Value.AddProductSize(l.Id, 100.99m, 25);
        tie5.Value.AddProductSize(m.Id, 100.99m, 25);
        tie5.Value.AddProductSize(s.Id, 100.99m, 25);

        tie5.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdY52Jq9kK2H8LUYBOmxX-WWdjsfYs392iiU1omVYFHwVcvkjjkdbCPKr3HocP_a0zMRQ&usqp=CAU");

        products.Add(tie1.Value);
        products.Add(tie2.Value);
        products.Add(tie3.Value);
        products.Add(tie4.Value);
        products.Add(tie5.Value);

        var sleepwear1 = Product.Create(sleepwearCloth!, brand1, sleepwear1Model!, blue!);
        sleepwear1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sleepwear1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sleepwear1.Value.AddProductSize(l.Id, 100.99m, 25);
        sleepwear1.Value.AddProductSize(m.Id, 100.99m, 25);
        sleepwear1.Value.AddProductSize(s.Id, 100.99m, 25);

        sleepwear1.Value.AddProductImage("https://assets.vogue.ru/photos/5eaadfb0166ba0cc6cf48eb8/2:3/w_2560%2Cc_limit/%25D0%25BF%25D0%25B81.jpg");

        var sleepwear2 = Product.Create(sleepwearCloth!, brand1, sleepwear1Model!, red!);
        sleepwear2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sleepwear2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sleepwear2.Value.AddProductSize(l.Id, 100.99m, 25);
        sleepwear2.Value.AddProductSize(m.Id, 100.99m, 25);
        sleepwear2.Value.AddProductSize(s.Id, 100.99m, 25);

        sleepwear2.Value.AddProductImage("https://content.rozetka.com.ua/goods/images/big/330015520.jpg");

        var sleepwear3 = Product.Create(sleepwearCloth!, brand1, sleepwear1Model!, green!);
        sleepwear3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sleepwear3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sleepwear3.Value.AddProductSize(l.Id, 100.99m, 25);
        sleepwear3.Value.AddProductSize(m.Id, 100.99m, 25);
        sleepwear3.Value.AddProductSize(s.Id, 100.99m, 25);

        sleepwear3.Value.AddProductImage("https://silkkiss.ua/images/detailed/12/2_3blm-98.jpg");

        var sleepwear4 = Product.Create(sleepwearCloth!, brand1, sleepwear1Model!, black!);
        sleepwear4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sleepwear4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sleepwear4.Value.AddProductSize(l.Id, 100.99m, 25);
        sleepwear4.Value.AddProductSize(m.Id, 100.99m, 25);
        sleepwear4.Value.AddProductSize(s.Id, 100.99m, 25);

        sleepwear4.Value.AddProductImage("https://images.prom.ua/3397070730_satinovaya-pizhama-victorias.jpg");

        var sleepwear5 = Product.Create(sleepwearCloth!, brand1, sleepwear1Model!, orange!);
        sleepwear5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sleepwear5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sleepwear5.Value.AddProductSize(l.Id, 100.99m, 25);
        sleepwear5.Value.AddProductSize(m.Id, 100.99m, 25);
        sleepwear5.Value.AddProductSize(s.Id, 100.99m, 25);

        sleepwear5.Value.AddProductImage("https://static.insales-cdn.com/images/products/1/8156/475054044/3971945001c23ac32446baf99cb5dc3f.jpg");

        products.Add(sleepwear1.Value);
        products.Add(sleepwear2.Value);
        products.Add(sleepwear3.Value);
        products.Add(sleepwear4.Value);
        products.Add(sleepwear5.Value);

        var swimwear1 = Product.Create(swimwearCloth!, brand1, swimwear1Model!, blue!);
        swimwear1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        swimwear1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        swimwear1.Value.AddProductSize(l.Id, 100.99m, 25);
        swimwear1.Value.AddProductSize(m.Id, 100.99m, 25);
        swimwear1.Value.AddProductSize(s.Id, 100.99m, 25);

        swimwear1.Value.AddProductImage("https://www.mimimood.ee/catalog/thumbnails/600x800/9/7/b/a/236a6c68-d0fd-4f17-a93a-1f5f0091914d-vCiV.jpg?v1360");

        var swimwear2 = Product.Create(swimwearCloth!, brand1, swimwear1Model!, red!);
        swimwear2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        swimwear2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        swimwear2.Value.AddProductSize(l.Id, 100.99m, 25);
        swimwear2.Value.AddProductSize(m.Id, 100.99m, 25);
        swimwear2.Value.AddProductSize(s.Id, 100.99m, 25);

        swimwear2.Value.AddProductImage("https://milashop.com.ua/image/cache/data/kupalniki/2304-0%20lorin-1000x1000.jpg");

        var swimwear3 = Product.Create(swimwearCloth!, brand1, swimwear1Model!, green!);
        swimwear3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        swimwear3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        swimwear3.Value.AddProductSize(l.Id, 100.99m, 25);
        swimwear3.Value.AddProductSize(m.Id, 100.99m, 25);
        swimwear3.Value.AddProductSize(s.Id, 100.99m, 25);

        swimwear3.Value.AddProductImage("https://silkkiss.ua/images/detailed/12/2_3blm-98.jpg");

        var swimwear4 = Product.Create(swimwearCloth!, brand1, swimwear1Model!, black!);
        swimwear4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        swimwear4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        swimwear4.Value.AddProductSize(l.Id, 100.99m, 25);
        swimwear4.Value.AddProductSize(m.Id, 100.99m, 25);
        swimwear4.Value.AddProductSize(s.Id, 100.99m, 25);

        swimwear4.Value.AddProductImage("https://images.prom.ua/3397070730_satinovaya-pizhama-victorias.jpg");

        var swimwear5 = Product.Create(swimwearCloth!, brand1, swimwear1Model!, orange!);
        swimwear5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        swimwear5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        swimwear5.Value.AddProductSize(l.Id, 100.99m, 25);
        swimwear5.Value.AddProductSize(m.Id, 100.99m, 25);
        swimwear5.Value.AddProductSize(s.Id, 100.99m, 25);

        swimwear5.Value.AddProductImage("https://www.mimimood.ee/catalog/thumbnails/600x800/9/7/b/a/236a6c68-d0fd-4f17-a93a-1f5f0091914d-vCiV.jpg?v1360");

        products.Add(swimwear1.Value);
        products.Add(swimwear2.Value);
        products.Add(swimwear3.Value);
        products.Add(swimwear4.Value);
        products.Add(swimwear5.Value);

        var scarve1 = Product.Create(scarvesCloth!, brand1, scarves1Model!, blue!);
        scarve1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        scarve1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        scarve1.Value.AddProductSize(l.Id, 100.99m, 25);
        scarve1.Value.AddProductSize(m.Id, 100.99m, 25);
        scarve1.Value.AddProductSize(s.Id, 100.99m, 25);

        scarve1.Value.AddProductImage("https://renome-fashion.ru/pictures/product/big/8770_big.png");

        var scarve2 = Product.Create(scarvesCloth!, brand1, scarves1Model!, red!);
        scarve2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        scarve2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        scarve2.Value.AddProductSize(l.Id, 100.99m, 25);
        scarve2.Value.AddProductSize(m.Id, 100.99m, 25);
        scarve2.Value.AddProductSize(s.Id, 100.99m, 25);

        scarve2.Value.AddProductImage("https://shop-cdn1-2.vigbo.tech/shops/173159/products/21021244/images/3-3262a56754684a5b228a30d8dbdf53d2.jpeg");

        var scarve3 = Product.Create(scarvesCloth!, brand1, scarves1Model!, green!);
        scarve3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        scarve3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        scarve3.Value.AddProductSize(l.Id, 100.99m, 25);
        scarve3.Value.AddProductSize(m.Id, 100.99m, 25);
        scarve3.Value.AddProductSize(s.Id, 100.99m, 25);

        scarve3.Value.AddProductImage("https://inspireshop.ru/upload/resize_cache/webp/upload/iblock/abb/1ajb66lq5g71a521r091szyy83yan7rv.webp");

        var scarve4 = Product.Create(scarvesCloth!, brand1, scarves1Model!, black!);
        scarve4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        scarve4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        scarve4.Value.AddProductSize(l.Id, 100.99m, 25);
        scarve4.Value.AddProductSize(m.Id, 100.99m, 25);
        scarve4.Value.AddProductSize(s.Id, 100.99m, 25);

        scarve4.Value.AddProductImage("https://shop-cdn1-2.vigbo.tech/shops/173159/products/21423559/images/2-19dbb21d6583cd28ac87434d9a5a8809.jpeg");

        var scarve5 = Product.Create(scarvesCloth!, brand1, scarves1Model!, orange!);
        scarve5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        scarve5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        scarve5.Value.AddProductSize(l.Id, 100.99m, 25);
        scarve5.Value.AddProductSize(m.Id, 100.99m, 25);
        scarve5.Value.AddProductSize(s.Id, 100.99m, 25);

        scarve5.Value.AddProductImage("https://royal-wool.ru/wp-content/uploads/2020/03/img_3314.jpg");

        products.Add(scarve1.Value);
        products.Add(scarve2.Value);
        products.Add(scarve3.Value);
        products.Add(scarve4.Value);
        products.Add(scarve5.Value);

        var outerwear1 = Product.Create(outerwearCloth!, brand1, outwear1Model!, blue!);
        outerwear1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        outerwear1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        outerwear1.Value.AddProductSize(l.Id, 100.99m, 25);
        outerwear1.Value.AddProductSize(m.Id, 100.99m, 25);
        outerwear1.Value.AddProductSize(s.Id, 100.99m, 25);

        outerwear1.Value.AddProductImage("https://cdn.sela.ru/wa-data/public/shop/products/52/77/137752/images/668200/668200.480x617.jpg");

        var outerwear2 = Product.Create(outerwearCloth!, brand1, outwear1Model!, red!);
        outerwear2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        outerwear2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        outerwear2.Value.AddProductSize(l.Id, 100.99m, 25);
        outerwear2.Value.AddProductSize(m.Id, 100.99m, 25);
        outerwear2.Value.AddProductSize(s.Id, 100.99m, 25);

        outerwear2.Value.AddProductImage("https://n1s1.hsmedia.ru/33/e7/5c/33e75c9d88fb29910abde8e5b63f6a40/400x600_1_c3806be9a1ad213c9c76984f4ee6d3f1@1000x1500_0xac120003_19592896951664554049.jpg");

        var outerwear3 = Product.Create(outerwearCloth!, brand1, outwear1Model!, green!);
        outerwear3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        outerwear3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        outerwear3.Value.AddProductSize(l.Id, 100.99m, 25);
        outerwear3.Value.AddProductSize(m.Id, 100.99m, 25);
        outerwear3.Value.AddProductSize(s.Id, 100.99m, 25);

        outerwear3.Value.AddProductImage("https://static.tildacdn.com/tild3838-3539-4539-a362-633661333234/ND6A1636.jpg");

        var outerwear4 = Product.Create(outerwearCloth!, brand1, outwear1Model!, black!);
        outerwear4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        outerwear4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        outerwear4.Value.AddProductSize(l.Id, 100.99m, 25);
        outerwear4.Value.AddProductSize(m.Id, 100.99m, 25);
        outerwear4.Value.AddProductSize(s.Id, 100.99m, 25);

        outerwear4.Value.AddProductImage("https://static.insales-cdn.com/images/products/1/2759/746220231/Gate_31_08_0472.jpg");

        var outerwear5 = Product.Create(outerwearCloth!, brand1, outwear1Model!, orange!);
        outerwear5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        outerwear5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        outerwear5.Value.AddProductSize(l.Id, 100.99m, 25);
        outerwear5.Value.AddProductSize(m.Id, 100.99m, 25);
        outerwear5.Value.AddProductSize(s.Id, 100.99m, 25);

        outerwear5.Value.AddProductImage("https://texmart.kg/storage/productions/production_648c70a3b224f.jpg");

        products.Add(outerwear1.Value);
        products.Add(outerwear2.Value);
        products.Add(outerwear3.Value);
        products.Add(outerwear4.Value);
        products.Add(outerwear5.Value);

        var bottoms1 = Product.Create(bottomsCloth!, brand1, bottoms1Model!, blue!);
        bottoms1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        bottoms1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        bottoms1.Value.AddProductSize(l.Id, 100.99m, 25);
        bottoms1.Value.AddProductSize(m.Id, 100.99m, 25);
        bottoms1.Value.AddProductSize(s.Id, 100.99m, 25);

        bottoms1.Value.AddProductImage("https://ae01.alicdn.com/kf/Hc0767cd72b444f05b8683a382f8d76dbq.jpg");

        var bottoms2 = Product.Create(bottomsCloth!, brand1, bottoms1Model!, red!);
        bottoms2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        bottoms2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        bottoms2.Value.AddProductSize(l.Id, 100.99m, 25);
        bottoms2.Value.AddProductSize(m.Id, 100.99m, 25);
        bottoms2.Value.AddProductSize(s.Id, 100.99m, 25);

        bottoms2.Value.AddProductImage("https://idealbra.ru/wp-content/uploads/2021/12/selenared_kal_02-scaled.jpg");

        var bottoms3 = Product.Create(bottomsCloth!, brand1, bottoms1Model!, green!);
        bottoms3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        bottoms3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        bottoms3.Value.AddProductSize(l.Id, 100.99m, 25);
        bottoms3.Value.AddProductSize(m.Id, 100.99m, 25);
        bottoms3.Value.AddProductSize(s.Id, 100.99m, 25);

        bottoms3.Value.AddProductImage("https://cdn.4stand.com/huge/d7/00/d700a06a5828df8a16591faba81f03d464225289.jpg");

        var bottoms4 = Product.Create(bottomsCloth!, brand1, bottoms1Model!, black!);
        bottoms4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        bottoms4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        bottoms4.Value.AddProductSize(l.Id, 100.99m, 25);
        bottoms4.Value.AddProductSize(m.Id, 100.99m, 25);
        bottoms4.Value.AddProductSize(s.Id, 100.99m, 25);

        bottoms4.Value.AddProductImage("https://lulight.ru/wp-content/uploads/2021/11/img_0167.jpeg");

        var bottoms5 = Product.Create(bottomsCloth!, brand1, bottoms1Model!, orange!);
        bottoms5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        bottoms5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        bottoms5.Value.AddProductSize(l.Id, 100.99m, 25);
        bottoms5.Value.AddProductSize(m.Id, 100.99m, 25);
        bottoms5.Value.AddProductSize(s.Id, 100.99m, 25);

        bottoms5.Value.AddProductImage("https://ae03.alicdn.com/kf/S9b8c0f816f764d4c8b6a484cace9994cn.jpg");

        products.Add(bottoms1.Value);
        products.Add(bottoms2.Value);
        products.Add(bottoms3.Value);
        products.Add(bottoms4.Value);
        products.Add(bottoms5.Value);

        var belts1 = Product.Create(beltsCloth!, brand1, belts1Model!, blue!);
        belts1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        belts1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        belts1.Value.AddProductSize(l.Id, 100.99m, 25);
        belts1.Value.AddProductSize(m.Id, 100.99m, 25);
        belts1.Value.AddProductSize(s.Id, 100.99m, 25);

        belts1.Value.AddProductImage("https://kanscraft.com/wp-content/uploads/2017/12/frame-36-701x701.jpg");

        var belts2 = Product.Create(beltsCloth!, brand1, belts1Model!, red!);
        belts2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        belts2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        belts2.Value.AddProductSize(l.Id, 100.99m, 25);
        belts2.Value.AddProductSize(m.Id, 100.99m, 25);
        belts2.Value.AddProductSize(s.Id, 100.99m, 25);

        belts2.Value.AddProductImage("https://kanscraft.com/wp-content/uploads/2022/12/frame-275-701x701.jpg");

        var belts3 = Product.Create(beltsCloth!, brand1, belts1Model!, green!);
        belts3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        belts3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        belts3.Value.AddProductSize(l.Id, 100.99m, 25);
        belts3.Value.AddProductSize(m.Id, 100.99m, 25);
        belts3.Value.AddProductSize(s.Id, 100.99m, 25);

        belts3.Value.AddProductImage("https://av-factory.ru/upload/iblock/b21/7rwfv5t3igls6g6mrcwxqq84jfv3azy4.jpg");

        var belts4 = Product.Create(beltsCloth!, brand1, belts1Model!, black!);
        belts4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        belts4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        belts4.Value.AddProductSize(l.Id, 100.99m, 25);
        belts4.Value.AddProductSize(m.Id, 100.99m, 25);
        belts4.Value.AddProductSize(s.Id, 100.99m, 25);

        belts4.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-m/c500/6249618298.jpg");

        var belts5 = Product.Create(beltsCloth!, brand1, belts1Model!, orange!);
        belts5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        belts5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        belts5.Value.AddProductSize(l.Id, 100.99m, 25);
        belts5.Value.AddProductSize(m.Id, 100.99m, 25);
        belts5.Value.AddProductSize(s.Id, 100.99m, 25);

        belts5.Value.AddProductImage("https://img.sellopt.ru/public/646/e7b/2f7/thumb_136939_1000_1000_0_0_auto.jpg");

        products.Add(belts1.Value);
        products.Add(belts2.Value);
        products.Add(belts3.Value);
        products.Add(belts4.Value);
        products.Add(belts5.Value);

        var activewear1 = Product.Create(activewearCloth!, brand1, activewear1Model!, blue!);
        activewear1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        activewear1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        activewear1.Value.AddProductSize(l.Id, 100.99m, 25);
        activewear1.Value.AddProductSize(m.Id, 100.99m, 25);
        activewear1.Value.AddProductSize(s.Id, 100.99m, 25);

        activewear1.Value.AddProductImage("https://stepup.kg/wp-content/uploads/2020/06/96.jpg");

        var activewear2 = Product.Create(activewearCloth!, brand1, activewear1Model!, red!);
        activewear2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        activewear2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        activewear2.Value.AddProductSize(l.Id, 100.99m, 25);
        activewear2.Value.AddProductSize(m.Id, 100.99m, 25);
        activewear2.Value.AddProductSize(s.Id, 100.99m, 25);

        activewear2.Value.AddProductImage("https://www.dossodossi.com/images/thumbs/107/1073142_1800.jpeg");

        var activewear3 = Product.Create(activewearCloth!, brand1, activewear1Model!, green!);
        activewear3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        activewear3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        activewear3.Value.AddProductSize(l.Id, 100.99m, 25);
        activewear3.Value.AddProductSize(m.Id, 100.99m, 25);
        activewear3.Value.AddProductSize(s.Id, 100.99m, 25);

        activewear3.Value.AddProductImage("https://img5.lalafo.com/i/posters/original/a6/ba/b3/customer-search-womens-clothing-mens-clothing-t-shirts-sportswear-svitshots-70269000_image-1668178385.jpeg");

        var activewear4 = Product.Create(activewearCloth!, brand1, activewear1Model!, black!);
        activewear4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        activewear4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        activewear4.Value.AddProductSize(l.Id, 100.99m, 25);
        activewear4.Value.AddProductSize(m.Id, 100.99m, 25);
        activewear4.Value.AddProductSize(s.Id, 100.99m, 25);

        activewear4.Value.AddProductImage("https://i.pinimg.com/736x/3b/fb/56/3bfb56038bd0431d14bf7b7b8d62f742.jpg");

        var activewear5 = Product.Create(activewearCloth!, brand1, activewear1Model!, orange!);
        activewear5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        activewear5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        activewear5.Value.AddProductSize(l.Id, 100.99m, 25);
        activewear5.Value.AddProductSize(m.Id, 100.99m, 25);
        activewear5.Value.AddProductSize(s.Id, 100.99m, 25);

        activewear5.Value.AddProductImage("https://bishkek.partner-moto.com/media/580/58054.webp");

        products.Add(activewear1.Value);
        products.Add(activewear2.Value);
        products.Add(activewear3.Value);
        products.Add(activewear4.Value);
        products.Add(activewear5.Value);

        var dresses1 = Product.Create(dressesCloth!, brand1, dresses1Model!, blue!);
        dresses1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        dresses1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        dresses1.Value.AddProductSize(l.Id, 100.99m, 25);
        dresses1.Value.AddProductSize(m.Id, 100.99m, 25);
        dresses1.Value.AddProductSize(s.Id, 100.99m, 25);

        dresses1.Value.AddProductImage("https://modde.ru/wa-data/public/shop/products/62/14/1462/images/6001/6001.970.jpg");

        var dresses2 = Product.Create(dressesCloth!, brand1, dresses1Model!, red!);
        dresses2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        dresses2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        dresses2.Value.AddProductSize(l.Id, 100.99m, 25);
        dresses2.Value.AddProductSize(m.Id, 100.99m, 25);
        dresses2.Value.AddProductSize(s.Id, 100.99m, 25);

        dresses2.Value.AddProductImage("https://i.pinimg.com/736x/ae/bc/94/aebc94e419a825abb96e47064508650d.jpg");

        var dresses3 = Product.Create(dressesCloth!, brand1, dresses1Model!, green!);
        dresses3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        dresses3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        dresses3.Value.AddProductSize(l.Id, 100.99m, 25);
        dresses3.Value.AddProductSize(m.Id, 100.99m, 25);
        dresses3.Value.AddProductSize(s.Id, 100.99m, 25);

        dresses3.Value.AddProductImage("https://storydress.ru/wp-content/uploads/vechernee-platye-delicious-dress-green-01.jpg");

        var dresses4 = Product.Create(dressesCloth!, brand1, dresses1Model!, black!);
        dresses4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        dresses4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        dresses4.Value.AddProductSize(l.Id, 100.99m, 25);
        dresses4.Value.AddProductSize(m.Id, 100.99m, 25);
        dresses4.Value.AddProductSize(s.Id, 100.99m, 25);

        dresses4.Value.AddProductImage("https://www.interstyle-spb.ru/assets/images/products/3482/vechernee-plate-krista-329-03-black-alt2.jpg");

        var dresses5 = Product.Create(dressesCloth!, brand1, dresses1Model!, orange!);
        dresses5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        dresses5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        dresses5.Value.AddProductSize(l.Id, 100.99m, 25);
        dresses5.Value.AddProductSize(m.Id, 100.99m, 25);
        dresses5.Value.AddProductSize(s.Id, 100.99m, 25);

        dresses5.Value.AddProductImage("https://shop-cdn1-2.vigbo.tech/shops/138413/products/21672870/images/3-9d8d6193bbc1629df0a7bc9b65c25139.jpg");

        products.Add(dresses1.Value);
        products.Add(dresses2.Value);
        products.Add(dresses3.Value);
        products.Add(dresses4.Value);
        products.Add(dresses5.Value);

        //Обувь
        var shoes1 = Product.Create(shoesShoes!, brand1, shoes1Model!, blue!);
        shoes1.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        shoes1.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        shoes1.Value.AddProductSize(forty.Id, 100.99m, 25);
        shoes1.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        shoes1.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        shoes1.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        shoes1.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        shoes1.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        shoes1.Value.AddProductImage("https://img.kwinto-shoes.ru/img/600x600/0005450_600_600.jpg");

        var shoes2 = Product.Create(shoesShoes!, brand1, shoes1Model!, red!);
        shoes2.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        shoes2.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        shoes2.Value.AddProductSize(forty.Id, 100.99m, 25);
        shoes2.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        shoes2.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        shoes2.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        shoes2.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        shoes2.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        shoes2.Value.AddProductImage("https://static.ticimax.cloud/cdn-cgi/image/width=-,quality=99/7357/uploads/urunresimleri/buyuk/temka-hakiki-suet-deri-kadin-kirmizi-t-c7b2ed.jpg");

        var shoes3 = Product.Create(shoesShoes!, brand1, shoes1Model!, green!);
        shoes3.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        shoes3.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        shoes3.Value.AddProductSize(forty.Id, 100.99m, 25);
        shoes3.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        shoes3.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        shoes3.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        shoes3.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        shoes3.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        shoes3.Value.AddProductImage("https://www.charuel.ru/upload/resize_cache/iblock/5cf/525_702_1/t0yddw8yjt7c625z95tk4ig4zngx1dh8.jpg");

        var shoes4 = Product.Create(shoesShoes!, brand1, shoes1Model!, black!);
        shoes4.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        shoes4.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        shoes4.Value.AddProductSize(forty.Id, 100.99m, 25);
        shoes4.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        shoes4.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        shoes4.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        shoes4.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        shoes4.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        shoes4.Value.AddProductImage("https://cdn.ekonika.ru/resize/w1920/upload/iblock/e73/9nguj1w10x1h23pnlyuabb0o6325dyd5/PM00200CN_03_black_23L_1.jpg?2496b7de");

        var shoes5 = Product.Create(shoesShoes!, brand1, shoes1Model!, orange!);
        shoes5.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        shoes5.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        shoes5.Value.AddProductSize(forty.Id, 100.99m, 25);
        shoes5.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        shoes5.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        shoes5.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        shoes5.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        shoes5.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        shoes5.Value.AddProductImage("https://st1.tsum.com/sig/dd569f61cbaf8dbdbf969ba988625ad7/width/1526/i/11/11/61/43/11116143-1249-3ee4-9966-3a128ea5f4c8.jpg");

        products.Add(shoes1.Value);
        products.Add(shoes2.Value);
        products.Add(shoes3.Value);
        products.Add(shoes4.Value);
        products.Add(shoes5.Value);

        var loafers1 = Product.Create(loafersShoes!, brand1, loafers1Model!, blue!);
        loafers1.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        loafers1.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        loafers1.Value.AddProductSize(forty.Id, 100.99m, 25);
        loafers1.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        loafers1.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        loafers1.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        loafers1.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        loafers1.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        loafers1.Value.AddProductImage("https://www.blacksides.ru/upload/resize_cache/iblock/62c/900_1200_1/62cd9ee82d57bb4adbf7a2ff62959ba9.jpg");

        var loafers2 = Product.Create(loafersShoes!, brand1, loafers1Model!, red!);
        loafers2.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        loafers2.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        loafers2.Value.AddProductSize(forty.Id, 100.99m, 25);
        loafers2.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        loafers2.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        loafers2.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        loafers2.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        loafers2.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        loafers2.Value.AddProductImage("https://fridaywear.ru/upload/resize_cache/webp/upload/iblock/013/013904aec00a8ab7f88a61816170f76c.webp");

        var loafers3 = Product.Create(loafersShoes!, brand1, loafers1Model!, green!);
        loafers3.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        loafers3.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        loafers3.Value.AddProductSize(forty.Id, 100.99m, 25);
        loafers3.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        loafers3.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        loafers3.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        loafers3.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        loafers3.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        loafers3.Value.AddProductImage("https://converse.org.ua/image/cache/catalog/easyphoto/677/kedy-converse-chuck-70-high-top-dark-green-168508c-3-1200x1200.jpg");

        var loafers4 = Product.Create(loafersShoes!, brand1, loafers1Model!, black!);
        loafers4.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        loafers4.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        loafers4.Value.AddProductSize(forty.Id, 100.99m, 25);
        loafers4.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        loafers4.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        loafers4.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        loafers4.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        loafers4.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        loafers4.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-8/c1000/6724621736.jpg");

        var loafers5 = Product.Create(loafersShoes!, brand1, loafers1Model!, orange!);
        loafers5.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        loafers5.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        loafers5.Value.AddProductSize(forty.Id, 100.99m, 25);
        loafers5.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        loafers5.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        loafers5.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        loafers5.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        loafers5.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        loafers5.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-4/c1000/6725575804.jpg");

        products.Add(loafers1.Value);
        products.Add(loafers2.Value);
        products.Add(loafers3.Value);
        products.Add(loafers4.Value);
        products.Add(loafers5.Value);

        var sneakers1 = Product.Create(sneakersShoes!, brand1, sneakers1Model!, blue!);
        sneakers1.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        sneakers1.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        sneakers1.Value.AddProductSize(forty.Id, 100.99m, 25);
        sneakers1.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        sneakers1.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        sneakers1.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        sneakers1.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        sneakers1.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        sneakers1.Value.AddProductImage("https://bruklin-store.ru/images/13.05.23/22.jpg");

        var sneakers2 = Product.Create(sneakersShoes!, brand1, sneakers1Model!, red!);
        sneakers2.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        sneakers2.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        sneakers2.Value.AddProductSize(forty.Id, 100.99m, 25);
        sneakers2.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        sneakers2.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        sneakers2.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        sneakers2.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        sneakers2.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        sneakers2.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-g/c500/6623237164.jpg");

        var sneakers3 = Product.Create(sneakersShoes!, brand1, sneakers1Model!, green!);
        sneakers3.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        sneakers3.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        sneakers3.Value.AddProductSize(forty.Id, 100.99m, 25);
        sneakers3.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        sneakers3.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        sneakers3.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        sneakers3.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        sneakers3.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        loafers3.Value.AddProductImage("https://myreact.ru/wp-content/uploads/2021/01/muzhskie-krossovki-jordan-air-jordan-1-low-white-black-mystic-green-0.jpg");

        var sneakers4 = Product.Create(sneakersShoes!, brand1, sneakers1Model!, black!);
        sneakers4.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        sneakers4.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        sneakers4.Value.AddProductSize(forty.Id, 100.99m, 25);
        sneakers4.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        sneakers4.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        sneakers4.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        sneakers4.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        sneakers4.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        sneakers4.Value.AddProductImage("https://images.izi.ua/301485629");

        var sneakers5 = Product.Create(sneakersShoes!, brand1, sneakers1Model!, orange!);
        sneakers5.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        sneakers5.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        sneakers5.Value.AddProductSize(forty.Id, 100.99m, 25);
        sneakers5.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        sneakers5.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        sneakers5.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        sneakers5.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        sneakers5.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        sneakers5.Value.AddProductImage("https://static.cdn.oskelly.ru/product/1363463/item-795c018c-01f0-47b6-941d-3b05d48d7f85.jpg");

        products.Add(sneakers1.Value);
        products.Add(sneakers2.Value);
        products.Add(sneakers3.Value);
        products.Add(sneakers4.Value);
        products.Add(sneakers5.Value);

        var flipFlops1 = Product.Create(flipFlopsShoes!, brand1, flipFlops1Model!, blue!);
        flipFlops1.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        flipFlops1.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        flipFlops1.Value.AddProductSize(forty.Id, 100.99m, 25);
        flipFlops1.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        flipFlops1.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        flipFlops1.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        flipFlops1.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        flipFlops1.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        flipFlops1.Value.AddProductImage("https://www.okabashi.com/cdn/shop/products/surf-mens-flip-flops-black-638716.jpg?v=1685995206");

        var flipFlops2 = Product.Create(flipFlopsShoes!, brand1, flipFlops1Model!, red!);
        flipFlops2.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        flipFlops2.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        flipFlops2.Value.AddProductSize(forty.Id, 100.99m, 25);
        flipFlops2.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        flipFlops2.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        flipFlops2.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        flipFlops2.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        flipFlops2.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        flipFlops2.Value.AddProductImage("https://www.artigianodelcuo.io/3722-thickbox_default/red-leather-thongs-sandals-for-men-handmade.jpg");

        var flipFlops3 = Product.Create(flipFlopsShoes!, brand1, flipFlops1Model!, green!);
        flipFlops3.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        flipFlops3.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        flipFlops3.Value.AddProductSize(forty.Id, 100.99m, 25);
        flipFlops3.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        flipFlops3.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        flipFlops3.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        flipFlops3.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        flipFlops3.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        flipFlops3.Value.AddProductImage("https://www.tradeinn.com/f/61/613459/havaianas-top-unisex-flip-flops.jpg");

        var flipFlops4 = Product.Create(flipFlopsShoes!, brand1, flipFlops1Model!, black!);
        flipFlops4.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        flipFlops4.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        flipFlops4.Value.AddProductSize(forty.Id, 100.99m, 25);
        flipFlops4.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        flipFlops4.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        flipFlops4.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        flipFlops4.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        flipFlops4.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        flipFlops4.Value.AddProductImage("https://contents.mediadecathlon.com/p1300008/e6bf2666e875012c89d6d5e73b83f5d0/p1300008.jpg?format=auto&quality=70&f=650x0?f=270x270&format=auto");

        var flipFlops5 = Product.Create(flipFlopsShoes!, brand1, flipFlops1Model!, orange!);
        flipFlops5.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        flipFlops5.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        flipFlops5.Value.AddProductSize(forty.Id, 100.99m, 25);
        flipFlops5.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        flipFlops5.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        flipFlops5.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        flipFlops5.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        flipFlops5.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        flipFlops5.Value.AddProductImage("https://www.icandyclothing.co.uk/wp-content/uploads/2020/02/Top-V-Or2.jpg");

        products.Add(flipFlops1.Value);
        products.Add(flipFlops2.Value);
        products.Add(flipFlops3.Value);
        products.Add(flipFlops4.Value);
        products.Add(flipFlops5.Value);

        var sandals1 = Product.Create(sandalsShoes!, brand1, sandals1Model!, blue!);
        sandals1.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(forty.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        sandals1.Value.AddProductImage("https://crocsone.com.ua/image/cache/catalog/products/Zhinochi-Crocs/Zhinochi-sandali-Crocs-LiteRide-360-Sandal-Women-NavyBlue-Grey-5-700x700.png");

        var sandals2 = Product.Create(sandalsShoes!, brand1, sandals1Model!, red!);
        sandals2.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        sandals2.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        sandals2.Value.AddProductSize(forty.Id, 100.99m, 25);
        sandals2.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        sandals2.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        sandals2.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        sandals2.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        sandals2.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        sandals2.Value.AddProductImage("https://forummultibrand.ru/upload/iblock/55d/L01A9497.JPG");

        var sandals3 = Product.Create(sandalsShoes!, brand1, sandals1Model!, green!);
        sandals3.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        sandals3.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        sandals3.Value.AddProductSize(forty.Id, 100.99m, 25);
        sandals3.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        sandals3.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        sandals3.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        sandals3.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        sandals3.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        sandals3.Value.AddProductImage("https://pompidou.ua/image/cache/catalog/!-3/1221/D3EF5281PIVC5002-1-800x900.jpg");

        var sandals4 = Product.Create(sandalsShoes!, brand1, sandals1Model!, black!);
        sandals4.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        sandals4.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        sandals4.Value.AddProductSize(forty.Id, 100.99m, 25);
        sandals4.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        sandals4.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        sandals4.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        sandals4.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        sandals4.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        sandals4.Value.AddProductImage("https://sportexpert.kg/wp-content/uploads/2021/05/Womens-Hiking-Black.jpg");

        var sandals5 = Product.Create(sandalsShoes!, brand1, sandals1Model!, orange!);
        sandals5.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        sandals5.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        sandals5.Value.AddProductSize(forty.Id, 100.99m, 25);
        sandals5.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        sandals5.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        sandals5.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        sandals5.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        sandals5.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        sandals5.Value.AddProductImage("https://img01.ztat.net/article/spp-media-p1/b6aa43911c744e51aa110e56882868da/65e0e6ee12b3451a83ad956211f7204b.jpg?imwidth=762");

        products.Add(sandals1.Value);
        products.Add(sandals2.Value);
        products.Add(sandals3.Value);
        products.Add(sandals4.Value);
        products.Add(sandals5.Value);

        var gumshoes1 = Product.Create(gumshoesShoes!, brand1, gumshoes1Model!, blue!);
        sandals1.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(forty.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        sandals1.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        sandals1.Value.AddProductImage("https://www.converse.com/dw/image/v2/BCZC_PRD/on/demandware.static/-/Sites-cnv-master-catalog/default/dwe88a9e6a/images/a_08/A06844C_A_08X1.jpg?sw=406");

        var gumshoes2 = Product.Create(gumshoesShoes!, brand1, gumshoes1Model!, red!);
        gumshoes2.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        gumshoes2.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        gumshoes2.Value.AddProductSize(forty.Id, 100.99m, 25);
        gumshoes2.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        gumshoes2.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        gumshoes2.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        gumshoes2.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        gumshoes2.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        gumshoes2.Value.AddProductImage("https://st3.depositphotos.com/6198262/13775/v/450/depositphotos_137759476-stock-illustration-sneakers-chucks-gumshoes.jpg");

        var gumshoes3 = Product.Create(gumshoesShoes!, brand1, gumshoes1Model!, green!);
        gumshoes3.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        gumshoes3.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        gumshoes3.Value.AddProductSize(forty.Id, 100.99m, 25);
        gumshoes3.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        gumshoes3.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        gumshoes3.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        gumshoes3.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        gumshoes3.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        gumshoes3.Value.AddProductImage("https://www.converse.com/dw/image/v2/BJJF_PRD/on/demandware.static/-/Sites-cnv-master-catalog-we/default/dw970b3b3c/images/a_08/A04544C_A_08X1.jpg");

        var gumshoes4 = Product.Create(gumshoesShoes!, brand1, gumshoes1Model!, black!);
        gumshoes4.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        gumshoes4.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        gumshoes4.Value.AddProductSize(forty.Id, 100.99m, 25);
        gumshoes4.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        gumshoes4.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        gumshoes4.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        gumshoes4.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        gumshoes4.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        gumshoes4.Value.AddProductImage("https://cdna.lystit.com/photos/rubbersole/9d0687f3/converse-Black-Shoes-high-top-Trainers-Chuck-Taylor-All-Star-blackblackegret.jpeg");

        var gumshoes5 = Product.Create(gumshoesShoes!, brand1, gumshoes1Model!, orange!);
        gumshoes5.Value.AddProductSize(thirtyEight.Id, 100.99m, 25);
        gumshoes5.Value.AddProductSize(thirtyNine.Id, 100.99m, 25);
        gumshoes5.Value.AddProductSize(forty.Id, 100.99m, 25);
        gumshoes5.Value.AddProductSize(fortyOne.Id, 100.99m, 25);
        gumshoes5.Value.AddProductSize(fortyTwo.Id, 100.99m, 25);
        gumshoes5.Value.AddProductSize(fortyThree.Id, 100.99m, 25);
        gumshoes5.Value.AddProductSize(fortyFour.Id, 100.99m, 25);
        gumshoes5.Value.AddProductSize(fortyFive.Id, 100.99m, 25);

        gumshoes5.Value.AddProductImage("https://www.converse.com/dw/image/v2/BJJF_PRD/on/demandware.static/-/Sites-cnv-master-catalog-we/default/dwb73645af/images/a_08/A04392C_A_08X1.jpg");

        products.Add(gumshoes1.Value);
        products.Add(gumshoes2.Value);
        products.Add(gumshoes3.Value);
        products.Add(gumshoes4.Value);
        products.Add(gumshoes5.Value);

        var watches1 = Product.Create(watchesCategory!, brand1, watches1Model!, blue!);
        watches1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        watches1.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        watches1.Value.AddProductSize(m.Id, 100.99m, 25);
        watches1.Value.AddProductSize(l.Id, 100.99m, 25);
        watches1.Value.AddProductSize(s.Id, 100.99m, 25);

        watches1.Value.AddProductImage("https://images.squarespace-cdn.com/content/v1/5c78138211f784469d4817df/02837c27-828a-4ad3-b0ed-574190f1abfe/IMG_7862.JPG");

        var watches2 = Product.Create(watchesCategory!, brand1, watches1Model!, red!);
        watches2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        watches2.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        watches2.Value.AddProductSize(m.Id, 100.99m, 25);
        watches2.Value.AddProductSize(l.Id, 100.99m, 25);
        watches2.Value.AddProductSize(s.Id, 100.99m, 25);

        watches2.Value.AddProductImage("https://images.squarespace-cdn.com/content/v1/5c78138211f784469d4817df/1680446289649-AB807OAG84SOJYUWIUHP/E0AEC7FB-89D6-4CA0-A3A8-3439EACB6FF6.jpeg");

        var watches3 = Product.Create(watchesCategory!, brand1, watches1Model!, green!);
        watches3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        watches3.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        watches3.Value.AddProductSize(m.Id, 100.99m, 25);
        watches3.Value.AddProductSize(l.Id, 100.99m, 25);
        watches3.Value.AddProductSize(s.Id, 100.99m, 25);

        watches3.Value.AddProductImage("https://images.squarespace-cdn.com/content/v1/5c78138211f784469d4817df/b8cd1a5d-acdf-4c3f-b09a-762d76bbdf29/IMG_8630.JPG");

        var watches4 = Product.Create(watchesCategory!, brand1, watches1Model!, black!);
        watches4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        watches4.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        watches4.Value.AddProductSize(m.Id, 100.99m, 25);
        watches4.Value.AddProductSize(l.Id, 100.99m, 25);
        watches4.Value.AddProductSize(s.Id, 100.99m, 25);

        watches4.Value.AddProductImage("https://fossil.scene7.com/is/image/FossilPartners/FS5503_main?$sfcc_fos_hi-res$");

        var watches5 = Product.Create(watchesCategory!, brand1, watches1Model!, orange!);
        watches5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        watches5.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        watches5.Value.AddProductSize(m.Id, 100.99m, 25);
        watches5.Value.AddProductSize(l.Id, 100.99m, 25);
        watches5.Value.AddProductSize(s.Id, 100.99m, 25);

        watches5.Value.AddProductImage("https://images.squarespace-cdn.com/content/v1/5c78138211f784469d4817df/15f963be-d156-4260-a5f8-a4b9cb05d93c/IMG_7011.JPG");

        products.Add(watches1.Value);
        products.Add(watches2.Value);
        products.Add(watches3.Value);
        products.Add(watches4.Value);
        products.Add(watches5.Value);

        var wallets1 = Product.Create(walletsCategory!, brand1, wallets1Model!, blue!);
        wallets1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        wallets1.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        wallets1.Value.AddProductSize(m.Id, 100.99m, 25);
        wallets1.Value.AddProductSize(l.Id, 100.99m, 25);
        wallets1.Value.AddProductSize(s.Id, 100.99m, 25);

        wallets1.Value.AddProductImage("https://cdn1.ozone.ru/s3/multimedia-5/6493103489.jpg");

        var wallets2 = Product.Create(walletsCategory!, brand1, wallets1Model!, red!);
        wallets2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        wallets2.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        wallets2.Value.AddProductSize(m.Id, 100.99m, 25);
        wallets2.Value.AddProductSize(l.Id, 100.99m, 25);
        wallets2.Value.AddProductSize(s.Id, 100.99m, 25);

        wallets2.Value.AddProductImage("https://thingz4girlz.com/wp-content/uploads/2021/12/16-011-2.webp");

        var wallets3 = Product.Create(walletsCategory!, brand1, wallets1Model!, green!);
        wallets3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        wallets3.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        wallets3.Value.AddProductSize(m.Id, 100.99m, 25);
        wallets3.Value.AddProductSize(l.Id, 100.99m, 25);
        wallets3.Value.AddProductSize(s.Id, 100.99m, 25);

        wallets3.Value.AddProductImage("https://img.ssensemedia.com/images/222230F040010_1/comme-des-garcons-wallets-orange-and-green-fluo-squares-half-zip-wallet.jpg");

        var wallets4 = Product.Create(walletsCategory!, brand1, wallets1Model!, black!);
        wallets4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        wallets4.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        wallets4.Value.AddProductSize(m.Id, 100.99m, 25);
        wallets4.Value.AddProductSize(l.Id, 100.99m, 25);
        wallets4.Value.AddProductSize(s.Id, 100.99m, 25);

        wallets4.Value.AddProductImage("https://www.noonmar.com/sports-wallet-for-men-black-orange-16684-53-B.jpg");

        var wallets5 = Product.Create(walletsCategory!, brand1, wallets1Model!, orange!);
        wallets5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        wallets5.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        wallets5.Value.AddProductSize(m.Id, 100.99m, 25);
        wallets5.Value.AddProductSize(l.Id, 100.99m, 25);
        wallets5.Value.AddProductSize(s.Id, 100.99m, 25);

        wallets5.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-j/c1000/6613942267.jpg");

        products.Add(wallets1.Value);
        products.Add(wallets2.Value);
        products.Add(wallets3.Value);
        products.Add(wallets4.Value);
        products.Add(wallets5.Value);

        var jewelry1 = Product.Create(jewelryCategory!, brand1, jewelry1Model!, blue!);
        jewelry1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        jewelry1.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        jewelry1.Value.AddProductSize(m.Id, 100.99m, 25);
        jewelry1.Value.AddProductSize(l.Id, 100.99m, 25);
        jewelry1.Value.AddProductSize(s.Id, 100.99m, 25);

        jewelry1.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTSLh3jf2j1vjOqt-BDUIYQA1bL_y5yNEeRB4KvfGzFNjajDmlFq7md7_3PNUF_g4qtSm8&usqp=CAU");

        var jewelry2 = Product.Create(jewelryCategory!, brand1, jewelry1Model!, red!);
        jewelry2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        jewelry2.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        jewelry2.Value.AddProductSize(m.Id, 100.99m, 25);
        jewelry2.Value.AddProductSize(l.Id, 100.99m, 25);
        jewelry2.Value.AddProductSize(s.Id, 100.99m, 25);

        jewelry2.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-9/c500/6735405573.jpg");

        var jewelry3 = Product.Create(jewelryCategory!, brand1, jewelry1Model!, green!);
        jewelry3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        jewelry3.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        jewelry3.Value.AddProductSize(m.Id, 100.99m, 25);
        jewelry3.Value.AddProductSize(l.Id, 100.99m, 25);
        jewelry3.Value.AddProductSize(s.Id, 100.99m, 25);

        jewelry3.Value.AddProductImage("https://i.etsystatic.com/19155243/r/il/bd6273/2041659706/il_fullxfull.2041659706_d0fa.jpg");

        var jewelry4 = Product.Create(jewelryCategory!, brand1, jewelry1Model!, black!);
        jewelry4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        jewelry4.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        jewelry4.Value.AddProductSize(m.Id, 100.99m, 25);
        jewelry4.Value.AddProductSize(l.Id, 100.99m, 25);
        jewelry4.Value.AddProductSize(s.Id, 100.99m, 25);

        jewelry4.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-k/c1000/6423374816.jpg");

        var jewelry5 = Product.Create(jewelryCategory!, brand1, jewelry1Model!, orange!);
        jewelry5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        jewelry5.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        jewelry5.Value.AddProductSize(m.Id, 100.99m, 25);
        jewelry5.Value.AddProductSize(l.Id, 100.99m, 25);
        jewelry5.Value.AddProductSize(s.Id, 100.99m, 25);

        jewelry5.Value.AddProductImage("https://i.etsystatic.com/5269890/r/il/a6fd08/22970684/il_fullxfull.22970684.jpg");

        products.Add(jewelry1.Value);
        products.Add(jewelry2.Value);
        products.Add(jewelry3.Value);
        products.Add(jewelry4.Value);
        products.Add(jewelry5.Value);

        var glovers1 = Product.Create(glovesCategory!, brand1, gloves1Model!, blue!);
        glovers1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        glovers1.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        glovers1.Value.AddProductSize(m.Id, 100.99m, 25);
        glovers1.Value.AddProductSize(l.Id, 100.99m, 25);
        glovers1.Value.AddProductSize(s.Id, 100.99m, 25);

        glovers1.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-x/c1000/6744818001.jpg");

        var glovers2 = Product.Create(glovesCategory!, brand1, gloves1Model!, red!);
        glovers2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        glovers2.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        glovers2.Value.AddProductSize(m.Id, 100.99m, 25);
        glovers2.Value.AddProductSize(l.Id, 100.99m, 25);
        glovers2.Value.AddProductSize(s.Id, 100.99m, 25);

        glovers2.Value.AddProductImage("https://cdn.27.ua/799/c6/ec/2606828_1.jpeg");

        var glovers3 = Product.Create(glovesCategory!, brand1, gloves1Model!, green!);
        glovers3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        glovers3.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        glovers3.Value.AddProductSize(m.Id, 100.99m, 25);
        glovers3.Value.AddProductSize(l.Id, 100.99m, 25);
        glovers3.Value.AddProductSize(s.Id, 100.99m, 25);

        glovers3.Value.AddProductImage("https://images.prom.ua/3276319920_w640_h640_perchatki-rezinovye-nitril.jpg");

        var glovers4 = Product.Create(glovesCategory!, brand1, gloves1Model!, black!);
        glovers4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        glovers4.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        glovers4.Value.AddProductSize(m.Id, 100.99m, 25);
        glovers4.Value.AddProductSize(l.Id, 100.99m, 25);
        glovers4.Value.AddProductSize(s.Id, 100.99m, 25);

        glovers4.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-c/c1000/6155793072.jpg");

        var glovers5 = Product.Create(glovesCategory!, brand1, gloves1Model!, orange!);
        glovers5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        glovers5.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        glovers5.Value.AddProductSize(m.Id, 100.99m, 25);
        glovers5.Value.AddProductSize(l.Id, 100.99m, 25);
        glovers5.Value.AddProductSize(s.Id, 100.99m, 25);

        glovers5.Value.AddProductImage("https://i.etsystatic.com/5269890/r/il/a6fd08/22970684/il_fullxfull.22970684.jpg");

        products.Add(glovers1.Value);
        products.Add(glovers2.Value);
        products.Add(glovers3.Value);
        products.Add(glovers4.Value);
        products.Add(glovers5.Value);

        var sunglasses1 = Product.Create(sunglassesCategory!, brand1, sunglasses1Model!, blue!);
        sunglasses1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sunglasses1.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        sunglasses1.Value.AddProductSize(m.Id, 100.99m, 25);
        sunglasses1.Value.AddProductSize(l.Id, 100.99m, 25);
        sunglasses1.Value.AddProductSize(s.Id, 100.99m, 25);

        sunglasses1.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-8/c1000/6586165160.jpg");

        var sunglasses2 = Product.Create(sunglassesCategory!, brand1, sunglasses1Model!, red!);
        sunglasses2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sunglasses2.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        sunglasses2.Value.AddProductSize(m.Id, 100.99m, 25);
        sunglasses2.Value.AddProductSize(l.Id, 100.99m, 25);
        sunglasses2.Value.AddProductSize(s.Id, 100.99m, 25);

        sunglasses2.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-8/c1000/6586165160.jpg");

        var sunglasses3 = Product.Create(sunglassesCategory!, brand1, sunglasses1Model!, green!);
        sunglasses3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sunglasses3.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        sunglasses3.Value.AddProductSize(m.Id, 100.99m, 25);
        sunglasses3.Value.AddProductSize(l.Id, 100.99m, 25);
        sunglasses3.Value.AddProductSize(s.Id, 100.99m, 25);

        sunglasses3.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-8/c1000/6586165160.jpg");

        var sunglasses4 = Product.Create(sunglassesCategory!, brand1, sunglasses1Model!, black!);
        sunglasses4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sunglasses4.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        sunglasses4.Value.AddProductSize(m.Id, 100.99m, 25);
        sunglasses4.Value.AddProductSize(l.Id, 100.99m, 25);
        sunglasses4.Value.AddProductSize(s.Id, 100.99m, 25);

        sunglasses4.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-8/c1000/6586165160.jpg");

        var sunglasses5 = Product.Create(sunglassesCategory!, brand1, sunglasses1Model!, orange!);
        sunglasses5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        sunglasses5.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        sunglasses5.Value.AddProductSize(m.Id, 100.99m, 25);
        sunglasses5.Value.AddProductSize(l.Id, 100.99m, 25);
        sunglasses5.Value.AddProductSize(s.Id, 100.99m, 25);

        sunglasses5.Value.AddProductImage("https://ir.ozone.ru/s3/multimedia-8/c1000/6586165160.jpg");

        products.Add(sunglasses1.Value);
        products.Add(sunglasses2.Value);
        products.Add(sunglasses3.Value);
        products.Add(sunglasses4.Value);
        products.Add(sunglasses5.Value);

        var handbags1 = Product.Create(handbagsCategory!, brand1, handbags1Model!, blue!);
        handbags1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        handbags1.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        handbags1.Value.AddProductSize(m.Id, 100.99m, 25);
        handbags1.Value.AddProductSize(l.Id, 100.99m, 25);
        handbags1.Value.AddProductSize(s.Id, 100.99m, 25);

        handbags1.Value.AddProductImage("https://m.media-amazon.com/images/I/81HWh26sZlL._AC_UF1000,1000_QL80_.jpg");

        var handbags2 = Product.Create(handbagsCategory!, brand1, handbags1Model!, red!);
        handbags2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        handbags2.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        handbags2.Value.AddProductSize(m.Id, 100.99m, 25);
        handbags2.Value.AddProductSize(l.Id, 100.99m, 25);
        handbags2.Value.AddProductSize(s.Id, 100.99m, 25);

        handbags2.Value.AddProductImage("https://m.media-amazon.com/images/I/81HWh26sZlL._AC_UF1000,1000_QL80_.jpg");

        var handbags3 = Product.Create(handbagsCategory!, brand1, handbags1Model!, green!);
        handbags3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        handbags3.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        handbags3.Value.AddProductSize(m.Id, 100.99m, 25);
        handbags3.Value.AddProductSize(l.Id, 100.99m, 25);
        handbags3.Value.AddProductSize(s.Id, 100.99m, 25);

        handbags3.Value.AddProductImage("https://m.media-amazon.com/images/I/81HWh26sZlL._AC_UF1000,1000_QL80_.jpg");

        var handbags4 = Product.Create(handbagsCategory!, brand1, handbags1Model!, black!);
        handbags4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        handbags4.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        handbags4.Value.AddProductSize(m.Id, 100.99m, 25);
        handbags4.Value.AddProductSize(l.Id, 100.99m, 25);
        handbags4.Value.AddProductSize(s.Id, 100.99m, 25);

        handbags4.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQyrm68Snk6d435FlTUclw33hU21RfY2dZ_9g&usqp=CAU");

        var handbags5 = Product.Create(handbagsCategory!, brand1, handbags1Model!, orange!);
        handbags5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        handbags5.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        handbags5.Value.AddProductSize(m.Id, 100.99m, 25);
        handbags5.Value.AddProductSize(l.Id, 100.99m, 25);
        handbags5.Value.AddProductSize(s.Id, 100.99m, 25);

        handbags5.Value.AddProductImage("https://m.media-amazon.com/images/I/81HWh26sZlL._AC_UF1000,1000_QL80_.jpg");

        products.Add(handbags1.Value);
        products.Add(handbags2.Value);
        products.Add(handbags3.Value);
        products.Add(handbags4.Value);
        products.Add(handbags5.Value);

        var hats1 = Product.Create(hatsCategory!, brand1, hats1Model!, blue!);
        hats1.Value.AddProductSize(xxl.Id, 100.99m, 25);
        hats1.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        hats1.Value.AddProductSize(m.Id, 100.99m, 25);
        hats1.Value.AddProductSize(l.Id, 100.99m, 25);
        hats1.Value.AddProductSize(s.Id, 100.99m, 25);

        hats1.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT1GsvabZkGdI6nvi0fDihq1P6hXSw73jkxTA&usqp=CAU");

        var hats2 = Product.Create(hatsCategory!, brand1, hats1Model!, red!);
        hats2.Value.AddProductSize(xxl.Id, 100.99m, 25);
        hats2.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        hats2.Value.AddProductSize(m.Id, 100.99m, 25);
        hats2.Value.AddProductSize(l.Id, 100.99m, 25);
        hats2.Value.AddProductSize(s.Id, 100.99m, 25);

        hats2.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT1GsvabZkGdI6nvi0fDihq1P6hXSw73jkxTA&usqp=CAU");

        var hats3 = Product.Create(hatsCategory!, brand1, hats1Model!, green!);
        hats3.Value.AddProductSize(xxl.Id, 100.99m, 25);
        hats3.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        hats3.Value.AddProductSize(m.Id, 100.99m, 25);
        hats3.Value.AddProductSize(l.Id, 100.99m, 25);
        hats3.Value.AddProductSize(s.Id, 100.99m, 25);

        hats3.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT1GsvabZkGdI6nvi0fDihq1P6hXSw73jkxTA&usqp=CAU");

        var hats4 = Product.Create(hatsCategory!, brand1, hats1Model!, black!);
        hats4.Value.AddProductSize(xxl.Id, 100.99m, 25);
        hats4.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        hats4.Value.AddProductSize(m.Id, 100.99m, 25);
        hats4.Value.AddProductSize(l.Id, 100.99m, 25);
        hats4.Value.AddProductSize(s.Id, 100.99m, 25);

        hats4.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT1GsvabZkGdI6nvi0fDihq1P6hXSw73jkxTA&usqp=CAU");

        var hats5 = Product.Create(hatsCategory!, brand1, hats1Model!, orange!);
        hats5.Value.AddProductSize(xxl.Id, 100.99m, 25);
        hats5.Value.AddProductSize(xxxl.Id, 100.99m, 25);
        hats5.Value.AddProductSize(m.Id, 100.99m, 25);
        hats5.Value.AddProductSize(l.Id, 100.99m, 25);
        hats5.Value.AddProductSize(s.Id, 100.99m, 25);

        hats5.Value.AddProductImage("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT1GsvabZkGdI6nvi0fDihq1P6hXSw73jkxTA&usqp=CAU");

        products.Add(hats1.Value);
        products.Add(hats2.Value);
        products.Add(hats3.Value);
        products.Add(hats4.Value);
        products.Add(hats5.Value);

        return products;
    }
}
