using ErrorOr;
using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ColorEntity;
using XWear.Domain.Entities.BrandEntity;
using XWear.Domain.Entities.ModelEntity;
using XWear.Domain.Entities.UserEntity;
using XWear.Domain.Entities.ImageEntity;
using XWear.Domain.Entities.CategoryEntity;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Entities.ProductSizeEntity;
using XWear.Domain.Entities.SizeEntity.ValueObjects;

namespace XWear.Domain.Entities.ProductEntity;

public sealed class Product : AggregateRoot<ProductId>
{
    private readonly List<User> _favoritByUsers = new();

    private readonly List<Image> _images = new();

    private readonly List<ProductSize> _productSizes = new();

    public DateTime CreatedDateTime { get; private set; }

    public DateTime UpdatedDateTime { get; private set; }

    public Category Category { get; private set; }

    public Color Color { get; private set; }

    public Brand Brand { get; private set; }

    public Model Model { get; private set; }

    public IReadOnlyCollection<User> FavoritByUsers => _favoritByUsers.ToList();

    public IReadOnlyCollection<Image> Images => _images.ToList();

    public IReadOnlyCollection<ProductSize> ProductSizes => _productSizes.ToList();

    private Product() : base(ProductId.CreateUnique())
    {
    }

    private Product(
        ProductId productId,
        Category category,
        Brand brand,
        Model model,
        Color color)
        : base(productId)
    {
        Id = productId;
        CreatedDateTime = DateTime.UtcNow;
        UpdatedDateTime = DateTime.UtcNow;
        Category = category;
        Brand = brand;
        Model = model;
        Color = color;
    }

    public static ErrorOr<Product> Create(
        Category category,
        Brand brand,
        Model model,
        Color color)
    {
        return new Product(
            ProductId.CreateUnique(),
            category,
            brand,
            model,
            color);
    }

    public void AddToFavorits(User user)
    {
        _favoritByUsers.Add(user);
    }

    public void AddProductImage(string imageUrl)
    {
        var imageResult = Image.Create(imageUrl, Id);
        
        _images.Add(imageResult.Value);
    }

    public void AddRangeProductSizes(List<ProductSize> productSizes)
    {
        _productSizes.AddRange(productSizes);
    }

    public void AddProductSize(SizeId sizeId, decimal price, int quantity)
    {
        var productSizes = ProductSize.Create(Id, sizeId, price, quantity);
        _productSizes.Add(productSizes.Value);
    }
}