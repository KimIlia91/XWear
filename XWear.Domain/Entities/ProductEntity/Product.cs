using XWear.Domain.Common.Models;
using XWear.Domain.Entities.SizeEntity;
using XWear.Domain.Entities.ColorEntity;
using XWear.Domain.Entities.BrandEntity;
using XWear.Domain.Entities.ModelEntity;
using XWear.Domain.Entities.CategoryEntity;
using XWear.Domain.Entities.FavoritParoductEntity;
using XWear.Domain.Entities.UserEntity.ValueObjects;
using XWear.Domain.Entities.ProductEntity.ValueObjects;

namespace XWear.Domain.Entities.ProductEntity;

public sealed class Product : Entity<ProductId>
{
    private readonly List<FavoritProduct> _favoritProducts = new();

    public decimal Price { get; private set; }

    public int Quantity { get; private set; }

    public string ImgUrl { get; private set; } = null!;

    public DateTime CreatedDateTime { get; private set; }

    public DateTime UpdatedDateTime { get; private set; }

    public Category Category { get; private set; }

    public Size Size { get; private set; }

    public Color Color { get; private set; }

    public Brand Brand { get; private set; }

    public Model Model { get; private set; }

    public IReadOnlyCollection<FavoritProduct> FavoritProducts => _favoritProducts.AsReadOnly();

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
        Category = category;
        Brand = brand;
        Model = model;
        Color = color;
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

    public void AddFavoritProduct(UserId userId)
    {
        var favoritProduct = new FavoritProduct(userId, Id);
        _favoritProducts.Add(favoritProduct);
    }
}