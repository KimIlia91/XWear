using XWear.Domain.Entities;
using XWear.Domain.Common.Enums;
using XWear.Domain.Common.Extensions;
using Microsoft.EntityFrameworkCore;

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

    public static async Task<List<Product>> CreateProductsAsync(ApplicationDbContext context)
    {
        var categories = await context.Categories.ToListAsync();

        var activewear = categories.First(c => c.Name == CategoryEnum.Activewear.GetDescription());
        var bottoms = categories.First(c => c.Name == CategoryEnum.Bottoms.GetDescription());
        var belts = categories.First(c => c.Name == CategoryEnum.Belts.GetDescription());
        var dresses = categories.First(c => c.Name == CategoryEnum.Dresses.GetDescription());
        var flipFlops = categories.First(c => c.Name == CategoryEnum.FlipFlops.GetDescription());
        var gloves = categories.First(c => c.Name == CategoryEnum.Gloves.GetDescription());
        var gumshoes = categories.First(c => c.Name == CategoryEnum.Gumshoes.GetDescription());
        var outerwear = categories.First(c => c.Name == CategoryEnum.Outerwear.GetDescription());
        var swimwear = categories.First(c => c.Name == CategoryEnum.Swimwear.GetDescription());
        var sneakers = categories.First(c => c.Name == CategoryEnum.Sneakers.GetDescription());
        var sandals = categories.First(c => c.Name == CategoryEnum.Sandals.GetDescription());
        var sleepwear = categories.First(c => c.Name == CategoryEnum.Sleepwear.GetDescription());
        var sunglasses = categories.First(c => c.Name == CategoryEnum.Sunglasses.GetDescription());
        var scarves = categories.First(c => c.Name == CategoryEnum.Scarves.GetDescription());
        var handbags = categories.First(c => c.Name == CategoryEnum.Handbags.GetDescription());
        var hats = categories.First(c => c.Name == CategoryEnum.Hats.GetDescription());
        var loafers = categories.First(c => c.Name == CategoryEnum.Loafers.GetDescription());
        var lingerie = categories.First(c => c.Name == CategoryEnum.Lingerie.GetDescription());
        var tops = categories.First(c => c.Name == CategoryEnum.Tops.GetDescription());
        var ties = categories.First(c => c.Name == CategoryEnum.Ties.GetDescription());
        var jewelry = categories.First(c => c.Name == CategoryEnum.Jewelry.GetDescription());
        var watches = categories.First(c => c.Name == CategoryEnum.Watches.GetDescription());
        var wallets = categories.First(c => c.Name == CategoryEnum.Wallets.GetDescription());

        var brands = await context.Brands.ToListAsync();

        var gucci = brands.First(c => c.Name == BrandEnum.Gucci.GetDescription());
        var timberland = brands.First(c => c.Name == BrandEnum.Timberland.GetDescription());
        var nike = brands.First(c => c.Name == BrandEnum.Nike.GetDescription());
        var adidas = brands.First(c => c.Name == BrandEnum.Adidas.GetDescription());
        var puma = brands.First(c => c.Name == BrandEnum.Puma.GetDescription());
        var geox = brands.First(c => c.Name == BrandEnum.Geox.GetDescription());
        var balenciaga = brands.First(c => c.Name == BrandEnum.Balenciaga.GetDescription());
        var prada = brands.First(c => c.Name == BrandEnum.Prada.GetDescription());
        var louisVuitton = brands.First(c => c.Name == BrandEnum.LouisVuitton.GetDescription());
        var dior = brands.First(c => c.Name == BrandEnum.Dior.GetDescription());
        var versace = brands.First(c => c.Name == BrandEnum.Versace.GetDescription());
        var newBalance = brands.First(c => c.Name == BrandEnum.NewBalance.GetDescription());
        var reebok = brands.First(c => c.Name == BrandEnum.Reebok.GetDescription());
        var underArmour = brands.First(c => c.Name == BrandEnum.UnderArmour.GetDescription());
        var saucony = brands.First(c => c.Name == BrandEnum.Saucony.GetDescription());
        var asics = brands.First(c => c.Name == BrandEnum.Asics.GetDescription());
        var mizuno = brands.First(c => c.Name == BrandEnum.Mizuno.GetDescription());
        var vans = brands.First(c => c.Name == BrandEnum.Vans.GetDescription());
        var chanel = brands.First(c => c.Name == BrandEnum.Chanel.GetDescription());
        var burberry = brands.First(c => c.Name == BrandEnum.Burberry.GetDescription());
        var valentino = brands.First(c => c.Name == BrandEnum.Valentino.GetDescription());

        var colors = await context.Colors.ToListAsync();

        var red = colors.First(c => c.Value == ColorEnum.Red);
        var blue = colors.First(c => c.Value == ColorEnum.Blue);
        var pink = colors.First(c => c.Value == ColorEnum.Pink);
        var black = colors.First(c => c.Value == ColorEnum.Black);
        var white = colors.First(c => c.Value == ColorEnum.White);
        var yellow = colors.First(c => c.Value == ColorEnum.Yellow);
        var violet = colors.First(c => c.Value == ColorEnum.Violet);
        var gray = colors.First(c => c.Value == ColorEnum.Gray);
        var green = colors.First(c => c.Value == ColorEnum.Green);
        var orange = colors.First(c => c.Value == ColorEnum.Orange);
        var brown = colors.First(c => c.Value == ColorEnum.Brown);
        var beige = colors.First(c => c.Value == ColorEnum.Beige);

        var sizes = await context.Sizes.ToListAsync();

        var S = sizes.First(s => s.Name == SizeEnum.S.GetDescription());
        var M = sizes.First(s => s.Name == SizeEnum.M.GetDescription());
        var L = sizes.First(s => s.Name == SizeEnum.L.GetDescription());
        var Xl = sizes.First(s => s.Name == SizeEnum.Xl.GetDescription());
        var Xxl = sizes.First(s => s.Name == SizeEnum.Xxl.GetDescription());
        var Xxxl = sizes.First(s => s.Name == SizeEnum.Xxxl.GetDescription());
        var ThirtyEight = sizes.First(s => s.Name == SizeEnum.ThirtyEight.GetDescription());
        var ThirtyNine = sizes.First(s => s.Name == SizeEnum.ThirtyNine.GetDescription());
        var Forty = sizes.First(s => s.Name == SizeEnum.Forty.GetDescription());
        var FortyOne = sizes.First(s => s.Name == SizeEnum.FortyOne.GetDescription());
        var FortyTwo = sizes.First(s => s.Name == SizeEnum.FortyTwo.GetDescription());
        var FortyThree = sizes.First(s => s.Name == SizeEnum.FortyThree.GetDescription());
        var FortyFour = sizes.First(s => s.Name == SizeEnum.FortyFour.GetDescription());
        var FortyFive = sizes.First(s => s.Name == SizeEnum.FortyFive.GetDescription());

        var models = await context.Models.ToListAsync();

        var activewearModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Activewear.GetDescription(), nameof(Model)));
        var bottomsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Bottoms.GetDescription(), nameof(Model)));
        var beltsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Belts.GetDescription(), nameof(Model)));
        var dressesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Dresses.GetDescription(), nameof(Model)));
        var flipFlopsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.FlipFlops.GetDescription(), nameof(Model)));
        var glovesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Gloves.GetDescription(), nameof(Model)));
        var gumshoesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Gumshoes.GetDescription(), nameof(Model)));
        var outerwearModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Outerwear.GetDescription(), nameof(Model)));
        var swimwearModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Swimwear.GetDescription(), nameof(Model)));
        var sneakersModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Sneakers.GetDescription(), nameof(Model)));
        var sandalsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Sandals.GetDescription(), nameof(Model)));
        var sleepwearModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Sleepwear.GetDescription(), nameof(Model)));
        var sunglassesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Sunglasses.GetDescription(), nameof(Model)));
        var scarvesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Scarves.GetDescription(), nameof(Model)));
        var handbagsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Handbags.GetDescription(), nameof(Model)));
        var hatsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Hats.GetDescription(), nameof(Model)));
        var loafersModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Loafers.GetDescription(), nameof(Model)));
        var lingerieModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Lingerie.GetDescription(), nameof(Model)));
        var topsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Tops.GetDescription(), nameof(Model)));
        var tiesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Ties.GetDescription(), nameof(Model)));
        var jewelryModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Jewelry.GetDescription(), nameof(Model)));
        var watchesModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Watches.GetDescription(), nameof(Model)));
        var walletsModel = models.First(c => c.Name == string.Join(" ", CategoryEnum.Wallets.GetDescription(), nameof(Model)));

        var products = new List<Product>();

        // Продукт 1
        var p1 = new Product
        {
            ImgUrl = "URL1",
            ModelId = activewearModel.Id,
            Model = activewearModel,
            CategoryId = activewear.Id,
            Category = activewear,
            BrandId = gucci.Id,
            Brand = gucci,
            ColorId = red.Id,
            Color = red,
        };

        var ps1 = ProductSizeSeedGenerator.Seed();
        var ps2 = ProductSizeSeedGenerator.Seed();
        var ps3 = ProductSizeSeedGenerator.Seed();
        var ps4 = ProductSizeSeedGenerator.Seed();
        var ps5 = ProductSizeSeedGenerator.Seed();
        var ps6 = ProductSizeSeedGenerator.Seed();

        ps1.SizeId = S.Id;
        ps2.SizeId = L.Id;
        ps3.SizeId = M.Id;
        ps4.SizeId = Xl.Id;
        ps5.SizeId = Xxl.Id;
        ps6.SizeId = Xxxl.Id;

        ps1.ProductId = p1.Id;
        ps2.ProductId = p1.Id;
        ps3.ProductId = p1.Id;
        ps4.ProductId = p1.Id;
        ps5.ProductId = p1.Id;
        ps6.ProductId = p1.Id;

        await context.ProductSizes.AddAsync(ps1);

        products.Add(p1);

        // Продукт 2
        var p2 = new Product
        {
            ImgUrl = "URL2",
            ModelId = bottomsModel.Id,
            Model = bottomsModel,
            CategoryId = bottoms.Id,
            Category = bottoms,
            BrandId = timberland.Id,
            Brand = timberland,
            ColorId = blue.Id,
            Color = blue,
        };

        var ps7 = ProductSizeSeedGenerator.Seed();
        var ps8 = ProductSizeSeedGenerator.Seed();
        var ps9 = ProductSizeSeedGenerator.Seed();
        var ps10 = ProductSizeSeedGenerator.Seed();
        var ps11 = ProductSizeSeedGenerator.Seed();
        var ps12 = ProductSizeSeedGenerator.Seed();

        ps7.SizeId = S.Id;
        ps8.SizeId = L.Id;
        ps9.SizeId = M.Id;
        ps10.SizeId = Xl.Id;
        ps11.SizeId = Xxl.Id;
        ps12.SizeId = Xxxl.Id;

        ps7.ProductId = p2.Id;
        ps8.ProductId = p2.Id;
        ps9.ProductId = p2.Id;
        ps10.ProductId = p2.Id;
        ps11.ProductId = p2.Id;
        ps12.ProductId = p2.Id;

        await context.ProductSizes.AddAsync(ps2);

        products.Add(p2);

        // Продукт 3
        var p3 = new Product
        {
            ImgUrl = "URL3",
            ModelId = beltsModel.Id,
            Model = beltsModel,
            CategoryId = belts.Id,
            Category = belts,
            BrandId = nike.Id,
            Brand = nike,
            ColorId = pink.Id,
            Color = pink,
        };

        var ps13 = ProductSizeSeedGenerator.Seed();
        var ps14 = ProductSizeSeedGenerator.Seed();
        var ps15 = ProductSizeSeedGenerator.Seed();
        var ps16 = ProductSizeSeedGenerator.Seed();
        var ps17 = ProductSizeSeedGenerator.Seed();
        var ps18 = ProductSizeSeedGenerator.Seed();

        ps13.SizeId = S.Id;
        ps14.SizeId = L.Id;
        ps15.SizeId = M.Id;
        ps16.SizeId = Xl.Id;
        ps17.SizeId = Xxl.Id;
        ps18.SizeId = Xxxl.Id;

        ps13.ProductId = p3.Id;
        ps14.ProductId = p3.Id;
        ps15.ProductId = p3.Id;
        ps16.ProductId = p3.Id;
        ps17.ProductId = p3.Id;
        ps18.ProductId = p3.Id;

        await context.ProductSizes.AddAsync(ps3);

        products.Add(p3);

        // Продукт 4
        var p4 = new Product
        {
            ImgUrl = "URL4",
            ModelId = dressesModel.Id,
            Model = dressesModel,
            CategoryId = dresses.Id,
            Category = dresses,
            BrandId = adidas.Id,
            Brand = adidas,
            ColorId = black.Id,
            Color = black,
        };

        var ps19 = ProductSizeSeedGenerator.Seed();
        var ps20 = ProductSizeSeedGenerator.Seed();
        var ps21 = ProductSizeSeedGenerator.Seed();
        var ps22 = ProductSizeSeedGenerator.Seed();
        var ps23 = ProductSizeSeedGenerator.Seed();
        var ps24 = ProductSizeSeedGenerator.Seed();

        ps19.SizeId = S.Id;
        ps20.SizeId = L.Id;
        ps21.SizeId = M.Id;
        ps22.SizeId = Xl.Id;
        ps23.SizeId = Xxl.Id;
        ps24.SizeId = Xxxl.Id;

        ps19.ProductId = p4.Id;
        ps20.ProductId = p4.Id;
        ps21.ProductId = p4.Id;
        ps22.ProductId = p4.Id;
        ps23.ProductId = p4.Id;
        ps24.ProductId = p4.Id;

        await context.ProductSizes.AddAsync(ps4);

        products.Add(p4);

        // Продукт 5
        var p5 = new Product
        {
            ImgUrl = "URL5",
            ModelId = flipFlopsModel.Id,
            Model = flipFlopsModel,
            CategoryId = flipFlops.Id,
            Category = flipFlops,
            BrandId = puma.Id,
            Brand = puma,
            ColorId = white.Id,
            Color = white,
        };

        var ps25 = ProductSizeSeedGenerator.Seed();
        var ps26 = ProductSizeSeedGenerator.Seed();
        var ps27 = ProductSizeSeedGenerator.Seed();
        var ps28 = ProductSizeSeedGenerator.Seed();
        var ps29 = ProductSizeSeedGenerator.Seed();
        var ps30 = ProductSizeSeedGenerator.Seed();

        ps25.SizeId = FortyOne.Id;
        ps26.SizeId = FortyTwo.Id;
        ps27.SizeId = FortyThree.Id;
        ps28.SizeId = FortyFour.Id;
        ps29.SizeId = FortyFive.Id;
        ps30.SizeId = ThirtyNine.Id;

        ps25.ProductId = p5.Id;
        ps26.ProductId = p5.Id;
        ps27.ProductId = p5.Id;
        ps28.ProductId = p5.Id;
        ps29.ProductId = p5.Id;
        ps30.ProductId = p5.Id;

        await context.ProductSizes.AddAsync(ps5);

        products.Add(p5);

        // Продукт 6
        var p6 = new Product
        {
            ImgUrl = "URL6",
            ModelId = glovesModel.Id,
            Model = glovesModel,
            CategoryId = gloves.Id,
            Category = gloves,
            BrandId = geox.Id,
            Brand = geox,
            ColorId = yellow.Id,
            Color = yellow,
        };

        var ps31 = ProductSizeSeedGenerator.Seed();
        var ps32 = ProductSizeSeedGenerator.Seed();
        var ps33 = ProductSizeSeedGenerator.Seed();
        var ps34 = ProductSizeSeedGenerator.Seed();
        var ps35 = ProductSizeSeedGenerator.Seed();
        var ps36 = ProductSizeSeedGenerator.Seed();

        ps31.SizeId = S.Id;
        ps32.SizeId = L.Id;
        ps33.SizeId = M.Id;
        ps34.SizeId = Xl.Id;
        ps35.SizeId = Xxl.Id;
        ps36.SizeId = Xxxl.Id;

        ps31.ProductId = p6.Id;
        ps32.ProductId = p6.Id;
        ps33.ProductId = p6.Id;
        ps34.ProductId = p6.Id;
        ps35.ProductId = p6.Id;
        ps36.ProductId = p6.Id;

        await context.ProductSizes.AddAsync(ps6);

        products.Add(p6);

        // Продукт 7
        var p7 = new Product
        {
            ImgUrl = "URL7",
            ModelId = gumshoesModel.Id,
            Model = gumshoesModel,
            CategoryId = gumshoes.Id,
            Category = gumshoes,
            BrandId = balenciaga.Id,
            Brand = balenciaga,
            ColorId = violet.Id,
            Color = violet,
        };

        var ps37 = ProductSizeSeedGenerator.Seed();
        var ps38 = ProductSizeSeedGenerator.Seed();
        var ps39 = ProductSizeSeedGenerator.Seed();
        var ps40 = ProductSizeSeedGenerator.Seed();
        var ps41 = ProductSizeSeedGenerator.Seed();
        var ps42 = ProductSizeSeedGenerator.Seed();

        ps37.SizeId = Forty.Id;
        ps38.SizeId = FortyFive.Id;
        ps39.SizeId = FortyFour.Id;
        ps40.SizeId = FortyThree.Id;
        ps41.SizeId = FortyOne.Id;
        ps42.SizeId = FortyTwo.Id;

        ps37.ProductId = p7.Id;
        ps38.ProductId = p7.Id;
        ps39.ProductId = p7.Id;
        ps40.ProductId = p7.Id;
        ps41.ProductId = p7.Id;
        ps42.ProductId = p7.Id;

        await context.ProductSizes.AddAsync(ps7);

        products.Add(p7);

        // Продукт 8
        var p8 = new Product
        {
            ImgUrl = "URL8",
            ModelId = outerwearModel.Id,
            Model = outerwearModel,
            CategoryId = outerwear.Id,
            Category = outerwear,
            BrandId = prada.Id,
            Brand = prada,
            ColorId = gray.Id,
            Color = gray,
        };

        var ps43 = ProductSizeSeedGenerator.Seed();
        var ps44 = ProductSizeSeedGenerator.Seed();
        var ps45 = ProductSizeSeedGenerator.Seed();
        var ps46 = ProductSizeSeedGenerator.Seed();
        var ps47 = ProductSizeSeedGenerator.Seed();
        var ps48 = ProductSizeSeedGenerator.Seed();

        ps43.SizeId = S.Id;
        ps44.SizeId = L.Id;
        ps45.SizeId = M.Id;
        ps46.SizeId = Xl.Id;
        ps47.SizeId = Xxl.Id;
        ps48.SizeId = Xxxl.Id;

        ps43.ProductId = p8.Id;
        ps44.ProductId = p8.Id;
        ps45.ProductId = p8.Id;
        ps46.ProductId = p8.Id;
        ps47.ProductId = p8.Id;
        ps48.ProductId = p8.Id;

        await context.ProductSizes.AddAsync(ps8);

        products.Add(p8);

        // Продукт 9
        var p9 = new Product
        {
            ImgUrl = "URL9",
            ModelId = swimwearModel.Id,
            Model = swimwearModel,
            CategoryId = swimwear.Id,
            Category = swimwear,
            BrandId = louisVuitton.Id,
            Brand = louisVuitton,
            ColorId = green.Id,
            Color = green,
        };

        var ps49 = ProductSizeSeedGenerator.Seed();
        var ps50 = ProductSizeSeedGenerator.Seed();
        var ps51 = ProductSizeSeedGenerator.Seed();
        var ps52 = ProductSizeSeedGenerator.Seed();
        var ps53 = ProductSizeSeedGenerator.Seed();
        var ps54 = ProductSizeSeedGenerator.Seed();

        ps49.SizeId = S.Id;
        ps50.SizeId = L.Id;
        ps51.SizeId = M.Id;
        ps52.SizeId = Xl.Id;
        ps53.SizeId = Xxl.Id;
        ps54.SizeId = Xxxl.Id;

        ps49.ProductId = p9.Id;
        ps50.ProductId = p9.Id;
        ps51.ProductId = p9.Id;
        ps52.ProductId = p9.Id;
        ps53.ProductId = p9.Id;
        ps54.ProductId = p9.Id;

        await context.ProductSizes.AddAsync(ps9);

        products.Add(p9);

        // Продукт 10
        var p10 = new Product
        {
            ImgUrl = "URL10",
            ModelId = sneakersModel.Id,
            Model = sneakersModel,
            CategoryId = sneakers.Id,
            Category = sneakers,
            BrandId = dior.Id,
            Brand = dior,
            ColorId = orange.Id,
            Color = orange,
        };

        var ps55 = ProductSizeSeedGenerator.Seed();
        var ps56 = ProductSizeSeedGenerator.Seed();
        var ps57 = ProductSizeSeedGenerator.Seed();
        var ps58 = ProductSizeSeedGenerator.Seed();
        var ps59 = ProductSizeSeedGenerator.Seed();
        var ps60 = ProductSizeSeedGenerator.Seed();

        ps55.SizeId = ThirtyNine.Id;
        ps56.SizeId = FortyFour.Id;
        ps57.SizeId = FortyFive.Id;
        ps58.SizeId = FortyOne.Id;
        ps59.SizeId = FortyTwo.Id;
        ps60.SizeId = FortyThree.Id;

        ps55.ProductId = p10.Id;
        ps56.ProductId = p10.Id;
        ps57.ProductId = p10.Id;
        ps58.ProductId = p10.Id;
        ps59.ProductId = p10.Id;
        ps60.ProductId = p10.Id;

        await context.ProductSizes.AddAsync(ps10);

        products.Add(p10);

        // Продукт 11
        var p11 = new Product
        {
            ImgUrl = "URL11",
            ModelId = sandalsModel.Id,
            Model = sandalsModel,
            CategoryId = sandals.Id,
            Category = sandals,
            BrandId = versace.Id,
            Brand = versace,
            ColorId = brown.Id,
            Color = brown,
        };

        var ps61 = ProductSizeSeedGenerator.Seed();
        var ps62 = ProductSizeSeedGenerator.Seed();
        var ps63 = ProductSizeSeedGenerator.Seed();
        var ps64 = ProductSizeSeedGenerator.Seed();
        var ps65 = ProductSizeSeedGenerator.Seed();
        var ps66 = ProductSizeSeedGenerator.Seed();

        ps61.SizeId = ThirtyEight.Id;
        ps62.SizeId = ThirtyNine.Id;
        ps63.SizeId = Forty.Id;
        ps64.SizeId = FortyOne.Id;
        ps65.SizeId = FortyTwo.Id;
        ps66.SizeId = FortyFour.Id;

        ps61.ProductId = p11.Id;
        ps62.ProductId = p11.Id;
        ps63.ProductId = p11.Id;
        ps64.ProductId = p11.Id;
        ps65.ProductId = p11.Id;
        ps66.ProductId = p11.Id;

        await context.ProductSizes.AddAsync(ps11);

        products.Add(p11);

        // Продукт 12
        var p12 = new Product
        {
            ImgUrl = "URL12",
            ModelId = sleepwearModel.Id,
            Model = sleepwearModel,
            CategoryId = sleepwear.Id,
            Category = sleepwear,
            BrandId = newBalance.Id,
            Brand = newBalance,
            ColorId = beige.Id,
            Color = beige,
        };

        var ps67 = ProductSizeSeedGenerator.Seed();
        var ps68 = ProductSizeSeedGenerator.Seed();
        var ps69 = ProductSizeSeedGenerator.Seed();
        var ps70 = ProductSizeSeedGenerator.Seed();
        var ps71 = ProductSizeSeedGenerator.Seed();
        var ps72 = ProductSizeSeedGenerator.Seed();

        ps67.SizeId = S.Id;
        ps68.SizeId = L.Id;
        ps69.SizeId = M.Id;
        ps70.SizeId = Xl.Id;
        ps71.SizeId = Xxl.Id;
        ps72.SizeId = Xxxl.Id;

        ps67.ProductId = p12.Id;
        ps68.ProductId = p12.Id;
        ps69.ProductId = p12.Id;
        ps70.ProductId = p12.Id;
        ps71.ProductId = p12.Id;
        ps72.ProductId = p12.Id;

        await context.ProductSizes.AddAsync(ps12);

        products.Add(p12);

        // Продукт 13
        var p13 = new Product
        {
            ImgUrl = "URL13",
            ModelId = sunglassesModel.Id,
            Model = sunglassesModel,
            CategoryId = sunglasses.Id,
            Category = sunglasses,
            BrandId = reebok.Id,
            Brand = reebok,
            ColorId = blue.Id,
            Color = blue,
        };

        var ps73 = ProductSizeSeedGenerator.Seed();
        var ps74 = ProductSizeSeedGenerator.Seed();
        var ps75 = ProductSizeSeedGenerator.Seed();
        var ps76 = ProductSizeSeedGenerator.Seed();
        var ps77 = ProductSizeSeedGenerator.Seed();
        var ps78 = ProductSizeSeedGenerator.Seed();

        ps73.SizeId = S.Id;
        ps74.SizeId = L.Id;
        ps75.SizeId = M.Id;
        ps76.SizeId = Xl.Id;
        ps77.SizeId = Xxl.Id;
        ps78.SizeId = Xxxl.Id;

        ps73.ProductId = p13.Id;
        ps74.ProductId = p13.Id;
        ps75.ProductId = p13.Id;
        ps76.ProductId = p13.Id;
        ps77.ProductId = p13.Id;
        ps78.ProductId = p13.Id;

        await context.ProductSizes.AddAsync(ps13);

        products.Add(p13);

        // Продукт 14
        var p14 = new Product
        {
            ImgUrl = "URL14",
            ModelId = scarvesModel.Id,
            Model = scarvesModel,
            CategoryId = scarves.Id,
            Category = scarves,
            BrandId = underArmour.Id,
            Brand = underArmour,
            ColorId = pink.Id,
            Color = pink,
        };

        var ps79 = ProductSizeSeedGenerator.Seed();
        var ps80 = ProductSizeSeedGenerator.Seed();
        var ps81 = ProductSizeSeedGenerator.Seed();
        var ps82 = ProductSizeSeedGenerator.Seed();
        var ps83 = ProductSizeSeedGenerator.Seed();
        var ps84 = ProductSizeSeedGenerator.Seed();

        ps79.SizeId = S.Id;
        ps80.SizeId = L.Id;
        ps81.SizeId = M.Id;
        ps82.SizeId = Xl.Id;
        ps83.SizeId = Xxl.Id;
        ps84.SizeId = Xxxl.Id;

        ps79.ProductId = p14.Id;
        ps80.ProductId = p14.Id;
        ps81.ProductId = p14.Id;
        ps82.ProductId = p14.Id;
        ps83.ProductId = p14.Id;
        ps84.ProductId = p14.Id;

        await context.ProductSizes.AddAsync(ps14);

        products.Add(p14);

        // Продукт 15
        var p15 = new Product
        {
            ImgUrl = "URL15",
            ModelId = handbagsModel.Id,
            Model = handbagsModel,
            CategoryId = handbags.Id,
            Category = handbags,
            BrandId = saucony.Id,
            Brand = saucony,
            ColorId = black.Id,
            Color = black,
        };

        var ps85 = ProductSizeSeedGenerator.Seed();
        var ps86 = ProductSizeSeedGenerator.Seed();
        var ps87 = ProductSizeSeedGenerator.Seed();
        var ps88 = ProductSizeSeedGenerator.Seed();
        var ps89 = ProductSizeSeedGenerator.Seed();
        var ps90 = ProductSizeSeedGenerator.Seed();

        ps85.SizeId = S.Id;
        ps86.SizeId = L.Id;
        ps87.SizeId = M.Id;
        ps88.SizeId = Xl.Id;
        ps89.SizeId = Xxl.Id;
        ps90.SizeId = Xxxl.Id;

        ps85.ProductId = p15.Id;
        ps86.ProductId = p15.Id;
        ps87.ProductId = p15.Id;
        ps88.ProductId = p15.Id;
        ps89.ProductId = p15.Id;
        ps90.ProductId = p15.Id;

        await context.ProductSizes.AddAsync(ps15);

        products.Add(p15);

        // Продолжайте создавать остальные продукты таким же образом для продуктов с номерами от 15 до 30.

        // Продукт 16
        var p16 = new Product
        {
            ImgUrl = "URL16",
            ModelId = hatsModel.Id,
            Model = hatsModel,
            CategoryId = hats.Id,
            Category = hats,
            BrandId = asics.Id,
            Brand = asics,
            ColorId = white.Id,
            Color = white,
        };

        var ps91 = ProductSizeSeedGenerator.Seed();
        var ps92 = ProductSizeSeedGenerator.Seed();
        var ps93 = ProductSizeSeedGenerator.Seed();
        var ps94 = ProductSizeSeedGenerator.Seed();
        var ps95 = ProductSizeSeedGenerator.Seed();
        var ps96 = ProductSizeSeedGenerator.Seed();

        ps91.SizeId = S.Id;
        ps92.SizeId = L.Id;
        ps93.SizeId = M.Id;
        ps94.SizeId = Xl.Id;
        ps95.SizeId = Xxl.Id;
        ps96.SizeId = Xxxl.Id;

        ps91.ProductId = p16.Id;
        ps92.ProductId = p16.Id;
        ps93.ProductId = p16.Id;
        ps94.ProductId = p16.Id;
        ps95.ProductId = p16.Id;
        ps96.ProductId = p16.Id;

        await context.ProductSizes.AddAsync(ps16);

        products.Add(p16);

        // Продукт 17
        var p17 = new Product
        {
            ImgUrl = "URL17",
            ModelId = loafersModel.Id,
            Model = loafersModel,
            CategoryId = loafers.Id,
            Category = loafers,
            BrandId = mizuno.Id,
            Brand = mizuno,
            ColorId = violet.Id,
            Color = violet,
        };

        var ps97 = ProductSizeSeedGenerator.Seed();
        var ps98 = ProductSizeSeedGenerator.Seed();
        var ps99 = ProductSizeSeedGenerator.Seed();
        var ps100 = ProductSizeSeedGenerator.Seed();
        var ps101 = ProductSizeSeedGenerator.Seed();
        var ps102 = ProductSizeSeedGenerator.Seed();

        ps97.SizeId = ThirtyEight.Id;
        ps98.SizeId = ThirtyNine.Id;
        ps99.SizeId = Forty.Id;
        ps100.SizeId = FortyOne.Id;
        ps101.SizeId = FortyTwo.Id;
        ps102.SizeId = FortyThree.Id;

        ps97.ProductId = p17.Id;
        ps98.ProductId = p17.Id;
        ps99.ProductId = p17.Id;
        ps100.ProductId = p17.Id;
        ps101.ProductId = p17.Id;
        ps102.ProductId = p17.Id;

        await context.ProductSizes.AddAsync(ps17);

        products.Add(p17);

        // Продукт 18
        var p18 = new Product
        {
            ImgUrl = "URL18",
            ModelId = lingerieModel.Id,
            Model = lingerieModel,
            CategoryId = lingerie.Id,
            Category = lingerie,
            BrandId = vans.Id,
            Brand = vans,
            ColorId = gray.Id,
            Color = gray,
        };

        var ps103 = ProductSizeSeedGenerator.Seed();
        var ps104 = ProductSizeSeedGenerator.Seed();
        var ps105 = ProductSizeSeedGenerator.Seed();
        var ps106 = ProductSizeSeedGenerator.Seed();
        var ps107 = ProductSizeSeedGenerator.Seed();
        var ps108 = ProductSizeSeedGenerator.Seed();

        ps103.SizeId = S.Id;
        ps104.SizeId = L.Id;
        ps105.SizeId = M.Id;
        ps106.SizeId = Xl.Id;
        ps107.SizeId = Xxl.Id;
        ps108.SizeId = Xxxl.Id;

        ps103.ProductId = p18.Id;
        ps104.ProductId = p18.Id;
        ps105.ProductId = p18.Id;
        ps106.ProductId = p18.Id;
        ps107.ProductId = p18.Id;
        ps108.ProductId = p18.Id;

        await context.ProductSizes.AddAsync(ps18);

        products.Add(p18);

        // Продукт 19
        var p19 = new Product
        {
            ImgUrl = "URL19",
            ModelId = topsModel.Id,
            Model = topsModel,
            CategoryId = tops.Id,
            Category = tops,
            BrandId = chanel.Id,
            Brand = chanel,
            ColorId = red.Id,
            Color = red,
        };

        var ps109 = ProductSizeSeedGenerator.Seed();
        var ps110 = ProductSizeSeedGenerator.Seed();
        var ps111 = ProductSizeSeedGenerator.Seed();
        var ps112 = ProductSizeSeedGenerator.Seed();
        var ps113 = ProductSizeSeedGenerator.Seed();
        var ps114 = ProductSizeSeedGenerator.Seed();

        ps109.SizeId = S.Id;
        ps110.SizeId = L.Id;
        ps111.SizeId = M.Id;
        ps112.SizeId = Xl.Id;
        ps113.SizeId = Xxl.Id;
        ps114.SizeId = Xxxl.Id;

        ps109.ProductId = p19.Id;
        ps110.ProductId = p19.Id;
        ps111.ProductId = p19.Id;
        ps112.ProductId = p19.Id;
        ps113.ProductId = p19.Id;
        ps114.ProductId = p19.Id;

        await context.ProductSizes.AddAsync(ps19);

        products.Add(p19);

        // Продукт 20
        var p20 = new Product
        {
            ImgUrl = "URL20",
            ModelId = walletsModel.Id,
            Model = walletsModel,
            CategoryId = wallets.Id,
            Category = wallets,
            BrandId = gucci.Id,
            Brand = gucci,
            ColorId = blue.Id,
            Color = blue,
        };

        var ps115 = ProductSizeSeedGenerator.Seed();
        var ps116 = ProductSizeSeedGenerator.Seed();
        var ps117 = ProductSizeSeedGenerator.Seed();
        var ps118 = ProductSizeSeedGenerator.Seed();
        var ps119 = ProductSizeSeedGenerator.Seed();
        var ps120 = ProductSizeSeedGenerator.Seed();

        ps115.SizeId = S.Id;
        ps116.SizeId = L.Id;
        ps117.SizeId = M.Id;
        ps118.SizeId = Xl.Id;
        ps119.SizeId = Xxl.Id;
        ps120.SizeId = Xxxl.Id;

        ps115.ProductId = p20.Id;
        ps116.ProductId = p20.Id;
        ps117.ProductId = p20.Id;
        ps118.ProductId = p20.Id;
        ps119.ProductId = p20.Id;
        ps120.ProductId = p20.Id;

        await context.ProductSizes.AddAsync(ps20);

        products.Add(p20);

        // Продукт 22
        var p22 = new Product
        {
            ImgUrl = "URL22",
            ModelId = jewelryModel.Id,
            Model = jewelryModel,
            CategoryId = jewelry.Id,
            Category = jewelry,
            BrandId = nike.Id,
            Brand = nike,
            ColorId = yellow.Id,
            Color = yellow,
        };

        var ps127 = ProductSizeSeedGenerator.Seed();
        var ps128 = ProductSizeSeedGenerator.Seed();
        var ps129 = ProductSizeSeedGenerator.Seed();
        var ps130 = ProductSizeSeedGenerator.Seed();
        var ps131 = ProductSizeSeedGenerator.Seed();
        var ps132 = ProductSizeSeedGenerator.Seed();

        ps127.SizeId = S.Id;
        ps128.SizeId = L.Id;
        ps129.SizeId = M.Id;
        ps130.SizeId = Xl.Id;
        ps131.SizeId = Xxl.Id;
        ps132.SizeId = Xxxl.Id;

        ps127.ProductId = p22.Id;
        ps128.ProductId = p22.Id;
        ps129.ProductId = p22.Id;
        ps130.ProductId = p22.Id;
        ps131.ProductId = p22.Id;
        ps132.ProductId = p22.Id;

        await context.ProductSizes.AddAsync(ps22);

        products.Add(p22);

        // Продолжайте создавать остальные продукты таким же образом для продуктов с номерами от 22 до 30.

        // Продукт 23
        var p23 = new Product
        {
            ImgUrl = "URL23",
            ModelId = walletsModel.Id,
            Model = walletsModel,
            CategoryId = wallets.Id,
            Category = wallets,
            BrandId = adidas.Id,
            Brand = adidas,
            ColorId = brown.Id,
            Color = brown,
        };

        var ps133 = ProductSizeSeedGenerator.Seed();
        var ps134 = ProductSizeSeedGenerator.Seed();
        var ps135 = ProductSizeSeedGenerator.Seed();
        var ps136 = ProductSizeSeedGenerator.Seed();
        var ps137 = ProductSizeSeedGenerator.Seed();
        var ps138 = ProductSizeSeedGenerator.Seed();

        ps133.SizeId = S.Id;
        ps134.SizeId = L.Id;
        ps135.SizeId = M.Id;
        ps136.SizeId = Xl.Id;
        ps137.SizeId = Xxl.Id;
        ps138.SizeId = Xxxl.Id;

        ps133.ProductId = p23.Id;
        ps134.ProductId = p23.Id;
        ps135.ProductId = p23.Id;
        ps136.ProductId = p23.Id;
        ps137.ProductId = p23.Id;
        ps138.ProductId = p23.Id;

        await context.ProductSizes.AddAsync(ps23);

        products.Add(p23);

        // Продолжайте создавать остальные продукты таким же образом для продуктов с номерами от 23 до 30.

        // Продукт 24
        var p24 = new Product
        {
            ImgUrl = "URL24",
            ModelId = watchesModel.Id,
            Model = watchesModel,
            CategoryId = watches.Id,
            Category = watches,
            BrandId = geox.Id,
            Brand = geox,
            ColorId = black.Id,
            Color = black,
        };

        var ps139 = ProductSizeSeedGenerator.Seed();
        var ps140 = ProductSizeSeedGenerator.Seed();
        var ps141 = ProductSizeSeedGenerator.Seed();
        var ps142 = ProductSizeSeedGenerator.Seed();
        var ps143 = ProductSizeSeedGenerator.Seed();
        var ps144 = ProductSizeSeedGenerator.Seed();

        ps139.SizeId = S.Id;
        ps140.SizeId = L.Id;
        ps141.SizeId = M.Id;
        ps142.SizeId = Xl.Id;
        ps143.SizeId = Xxl.Id;
        ps144.SizeId = Xxxl.Id;

        ps139.ProductId = p24.Id;
        ps140.ProductId = p24.Id;
        ps141.ProductId = p24.Id;
        ps142.ProductId = p24.Id;
        ps143.ProductId = p24.Id;
        ps144.ProductId = p24.Id;

        await context.ProductSizes.AddAsync(ps24);

        products.Add(p24);

        // Продукт 25
        var p25 = new Product
        {
            ImgUrl = "URL25",
            ModelId = bottomsModel.Id,
            Model = bottomsModel,
            CategoryId = bottoms.Id,
            Category = bottoms,
            BrandId = louisVuitton.Id,
            Brand = louisVuitton,
            ColorId = blue.Id,
            Color = blue,
        };

        var ps145 = ProductSizeSeedGenerator.Seed();
        var ps146 = ProductSizeSeedGenerator.Seed();
        var ps147 = ProductSizeSeedGenerator.Seed();
        var ps148 = ProductSizeSeedGenerator.Seed();
        var ps149 = ProductSizeSeedGenerator.Seed();
        var ps150 = ProductSizeSeedGenerator.Seed();

        ps145.SizeId = S.Id;
        ps146.SizeId = L.Id;
        ps147.SizeId = M.Id;
        ps148.SizeId = Xl.Id;
        ps149.SizeId = Xxl.Id;
        ps150.SizeId = Xxxl.Id;

        ps145.ProductId = p25.Id;
        ps146.ProductId = p25.Id;
        ps147.ProductId = p25.Id;
        ps148.ProductId = p25.Id;
        ps149.ProductId = p25.Id;
        ps150.ProductId = p25.Id;

        await context.ProductSizes.AddAsync(ps25);

        products.Add(p25);

        // Продолжайте создавать остальные продукты таким же образом для продуктов с номерами от 25 до 30.

        // Продукт 26
        var p26 = new Product
        {
            ImgUrl = "URL26",
            ModelId = glovesModel.Id,
            Model = glovesModel,
            CategoryId = gloves.Id,
            Category = gloves,
            BrandId = balenciaga.Id,
            Brand = balenciaga,
            ColorId = green.Id,
            Color = green,
        };

        var ps151 = ProductSizeSeedGenerator.Seed();
        var ps152 = ProductSizeSeedGenerator.Seed();
        var ps153 = ProductSizeSeedGenerator.Seed();
        var ps154 = ProductSizeSeedGenerator.Seed();
        var ps155 = ProductSizeSeedGenerator.Seed();
        var ps156 = ProductSizeSeedGenerator.Seed();

        ps151.SizeId = S.Id;
        ps152.SizeId = L.Id;
        ps153.SizeId = M.Id;
        ps154.SizeId = Xl.Id;
        ps155.SizeId = Xxl.Id;
        ps156.SizeId = Xxxl.Id;

        ps151.ProductId = p26.Id;
        ps152.ProductId = p26.Id;
        ps153.ProductId = p26.Id;
        ps154.ProductId = p26.Id;
        ps155.ProductId = p26.Id;
        ps156.ProductId = p26.Id;

        await context.ProductSizes.AddAsync(ps26);

        products.Add(p26);

        // Продукт 27
        var p27 = new Product
        {
            ImgUrl = "URL27",
            ModelId = activewearModel.Id,
            Model = activewearModel,
            CategoryId = activewear.Id,
            Category = activewear,
            BrandId = prada.Id,
            Brand = prada,
            ColorId = pink.Id,
            Color = pink,
        };

        var ps157 = ProductSizeSeedGenerator.Seed();
        var ps158 = ProductSizeSeedGenerator.Seed();
        var ps159 = ProductSizeSeedGenerator.Seed();
        var ps160 = ProductSizeSeedGenerator.Seed();
        var ps161 = ProductSizeSeedGenerator.Seed();
        var ps162 = ProductSizeSeedGenerator.Seed();

        ps157.SizeId = S.Id;
        ps158.SizeId = L.Id;
        ps159.SizeId = M.Id;
        ps160.SizeId = Xl.Id;
        ps161.SizeId = Xxl.Id;
        ps162.SizeId = Xxxl.Id;

        ps157.ProductId = p27.Id;
        ps158.ProductId = p27.Id;
        ps159.ProductId = p27.Id;
        ps160.ProductId = p27.Id;
        ps161.ProductId = p27.Id;
        ps162.ProductId = p27.Id;

        await context.ProductSizes.AddAsync(ps27);

        products.Add(p27);

        // Продукт 28
        var p28 = new Product
        {
            ImgUrl = "URL28",
            ModelId = dressesModel.Id,
            Model = dressesModel,
            CategoryId = dresses.Id,
            Category = dresses,
            BrandId = saucony.Id,
            Brand = saucony,
            ColorId = black.Id,
            Color = black,
        };

        var ps163 = ProductSizeSeedGenerator.Seed();
        var ps164 = ProductSizeSeedGenerator.Seed();
        var ps165 = ProductSizeSeedGenerator.Seed();
        var ps166 = ProductSizeSeedGenerator.Seed();
        var ps167 = ProductSizeSeedGenerator.Seed();
        var ps168 = ProductSizeSeedGenerator.Seed();

        ps163.SizeId = S.Id;
        ps164.SizeId = L.Id;
        ps165.SizeId = M.Id;
        ps166.SizeId = Xl.Id;
        ps167.SizeId = Xxl.Id;
        ps168.SizeId = Xxxl.Id;

        ps163.ProductId = p28.Id;
        ps164.ProductId = p28.Id;
        ps165.ProductId = p28.Id;
        ps166.ProductId = p28.Id;
        ps167.ProductId = p28.Id;
        ps168.ProductId = p28.Id;

        await context.ProductSizes.AddAsync(ps28);

        products.Add(p28);

        // Продукт 29
        var p29 = new Product
        {
            ImgUrl = "URL29",
            ModelId = flipFlopsModel.Id,
            Model = flipFlopsModel,
            CategoryId = flipFlops.Id,
            Category = flipFlops,
            BrandId = newBalance.Id,
            Brand = newBalance,
            ColorId = white.Id,
            Color = white,
        };

        var ps169 = ProductSizeSeedGenerator.Seed();
        var ps170 = ProductSizeSeedGenerator.Seed();
        var ps171 = ProductSizeSeedGenerator.Seed();
        var ps172 = ProductSizeSeedGenerator.Seed();
        var ps173 = ProductSizeSeedGenerator.Seed();
        var ps174 = ProductSizeSeedGenerator.Seed();

        ps169.SizeId = ThirtyEight.Id;
        ps170.SizeId = ThirtyNine.Id;
        ps171.SizeId = Forty.Id;
        ps172.SizeId = FortyOne.Id;
        ps173.SizeId = FortyTwo.Id;
        ps174.SizeId = FortyThree.Id;

        await context.ProductSizes.AddAsync(ps29);

        products.Add(p29);

        // Продукт 30
        var p30 = new Product
        {
            ImgUrl = "URL30",
            ModelId = gumshoesModel.Id,
            Model = gumshoesModel,
            CategoryId = gumshoes.Id,
            Category = gumshoes,
            BrandId = dior.Id,
            Brand = dior,
            ColorId = blue.Id,
            Color = blue,
        };

        var ps175 = ProductSizeSeedGenerator.Seed();
        var ps176 = ProductSizeSeedGenerator.Seed();
        var ps177 = ProductSizeSeedGenerator.Seed();
        var ps178 = ProductSizeSeedGenerator.Seed();
        var ps179 = ProductSizeSeedGenerator.Seed();
        var ps180 = ProductSizeSeedGenerator.Seed();
        var ps181 = ProductSizeSeedGenerator.Seed();
        var ps182 = ProductSizeSeedGenerator.Seed();

        ps175.SizeId = ThirtyEight.Id;
        ps176.SizeId = ThirtyNine.Id;
        ps177.SizeId = Forty.Id;
        ps178.SizeId = FortyOne.Id;
        ps179.SizeId = FortyTwo.Id;
        ps180.SizeId = FortyThree.Id;
        ps181.SizeId = FortyFour.Id;
        ps182.SizeId = FortyFive.Id;


        ps175.ProductId = p30.Id;
        ps176.ProductId = p30.Id;
        ps177.ProductId = p30.Id;
        ps178.ProductId = p30.Id;
        ps179.ProductId = p30.Id;
        ps180.ProductId = p30.Id;

        await context.ProductSizes.AddAsync(ps30);

        products.Add(p30);

        return products;
    }
}
