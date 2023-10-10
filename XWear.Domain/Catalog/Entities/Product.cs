using XWear.Domain.Common.Models;
using XWear.Domain.Catalog.ValueObjects;
using XWear.Domain.FavoritProduct.ValueObjects;

namespace XWear.Domain.Catalog.Entities;

public sealed class Product : Entity<ProductId>
{
    private readonly List<FavoriteProduct> _favoriteByUsers = new();

    public decimal Price { get; private set; }

    public int Quantity { get; private set; }

    public string ImgUrl { get; private set; } = null!;

    public DateTime CreatedDateTime { get; private set; }

    public DateTime UpdatedDateTime { get; private set; }

    public SizeId SizeId { get; private set; }
    public Size Size { get; private set; }

    public ColorId ColorId { get; private set; }
    public Color Color { get; private set; }

    public BrandId BrandId { get; private set; }
    public Brand Brand { get; private set; }

    public ModelId ModelId { get; private set; }
    public Model Model { get; private set; }

    public IReadOnlyList<FavoriteProduct> FavoriteByUsers => _favoriteByUsers.AsReadOnly();

    internal Product(
        ProductId productId, 
        decimal price, 
        int quantity, 
        string imgUrl, 
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
        BrandId = brand.Id;
        Brand = brand;
        ModelId = model.Id;
        Model = model;
        ColorId = color.Id;
        Color = color;
        SizeId = size.Id;
        Size = size;
    }

    public Product Create(
        decimal price, 
        int quantity,
        string imgUrl,
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
            brand,
            model,
            size,
            color);
    }

    public FavoriteProductId AddProductToFavoritUser(
        UserId userId, 
        ProductId productId)
    {
        var favoritProduct = new FavoriteProduct(userId, productId);
        _favoriteByUsers.Add(favoritProduct);
        return favoritProduct.Id;
    }
}