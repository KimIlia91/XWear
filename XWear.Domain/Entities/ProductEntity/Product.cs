using XWear.Domain.Common.Models;
using XWear.Domain.Entities.BrandEntity;
using XWear.Domain.Entities.CategoryEntity;
using XWear.Domain.Entities.ColorEntity;
using XWear.Domain.Entities.FavoritParoductEntity;
using XWear.Domain.Entities.ModelEntity;
using XWear.Domain.Entities.SizeEntity;
using XWear.Domain.Entities.BrandEntity.ValueObjects;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Entities.FavoritParoductEntity.ValueObjects;
using XWear.Domain.Entities.ModelEntity.ValueObjects;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Entities.SizeEntity.ValueObjects;
using XWear.Domain.Entities.UserEntity.ValueObjects;

namespace XWear.Domain.Entities.ProductEntity;

public sealed class Product : AggregateRoot<ProductId>
{
    private readonly List<FavoritProduct> _favoriteByUsers = new();

    public decimal Price { get; private set; }

    public int Quantity { get; private set; }

    public string ImgUrl { get; private set; } = null!;

    public DateTime CreatedDateTime { get; private set; }

    public DateTime UpdatedDateTime { get; private set; }

    public CategoryId CategoryId { get; private set; }
    public Category Category { get; private set; }

    public SizeId SizeId { get; private set; }
    public Size Size { get; private set; }

    public ColorId ColorId { get; private set; }
    public Color Color { get; private set; }

    public BrandId BrandId { get; private set; }
    public Brand Brand { get; private set; }

    public ModelId ModelId { get; private set; }
    public Model Model { get; private set; }

    public IReadOnlyList<FavoritProduct> FavoriteByUsers => _favoriteByUsers.AsReadOnly();

    internal Product(
        ProductId productId,
        decimal price,
        int quantity,
        string imgUrl,
        Category category,
        Brand brand,
        Model model,
        Size size,
        Color color)
        : base(productId)
    {
        Price = price;
        Quantity = quantity;
        ImgUrl = imgUrl;
        CreatedDateTime = DateTime.UtcNow;
        UpdatedDateTime = DateTime.UtcNow;
        CategoryId = category.Id;
        Category = category;
        BrandId = brand.Id;
        Brand = brand;
        ModelId = model.Id;
        Model = model;
        ColorId = color.Id;
        Color = color;
        SizeId = size.Id;
        Size = size;
    }

    public static Product Create(
        decimal price,
        int quantity,
        string imgUrl,
        Category category,
        Brand brand,
        Model model,
        Size size,
        Color color)
    {
        return new(
            ProductId.CreateUnique(),
            price,
            quantity,
            imgUrl,
            category,
            brand,
            model,
            size,
            color);
    }

    public FavoriteProductId AddProductToFavoritUser(
        UserId userId,
        ProductId productId)
    {
        var favoritProduct = new FavoritProduct(userId, productId);
        _favoriteByUsers.Add(favoritProduct);
        return favoritProduct.Id;
    }
}