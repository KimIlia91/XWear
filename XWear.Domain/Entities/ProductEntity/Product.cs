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
using XWear.Domain.Entities.ImageEntity.ValueObjects;
using XWear.Domain.Entities.ProductSizeEntity.ValueObjects;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Entities.BrandEntity.ValueObjects;
using XWear.Domain.Entities.ModelEntity.ValueObjects;

namespace XWear.Domain.Entities.ProductEntity;

public sealed class Product : AggregateRoot<ProductId>
{
    private readonly List<User> _favoritByUsers = new();

    private readonly List<Image> _images = new();

    private readonly List<ProductSize> _productSizes = new();

    public DateTime CreatedDateTime { get; private set; }

    public DateTime UpdatedDateTime { get; private set; }

    public CategoryId CategoryId { get; private set; }

    public Category? Category { get; private set; }

    public ColorId ColorId { get; private set; }

    public Color? Color { get; set; }

    public BrandId BrandId { get; private set; }

    public Brand? Brand { get; set; }

    public ModelId ModelId { get; private set; }

    public Model? Model { get; private set; }

    public IReadOnlyCollection<User> FavoritByUsers => _favoritByUsers.ToList();

    public IReadOnlyCollection<Image> Images => _images.ToList();

    public IReadOnlyCollection<ProductSize> ProductSizes => _productSizes.ToList();

    private Product() : base(ProductId.CreateUnique())
    {
    }

    private Product(
        ProductId productId,
        CategoryId category,
        BrandId brand,
        ModelId model,
        ColorId color)
        : base(productId)
    {
        Id = productId;
        CreatedDateTime = DateTime.UtcNow;
        UpdatedDateTime = DateTime.UtcNow;
        CategoryId = category;
        BrandId = brand;
        ModelId = model;
        ColorId = color;
    }

    public static ErrorOr<Product> Create(
        CategoryId category,
        BrandId brand,
        ModelId model,
        ColorId color)
    {
        return new Product(
            ProductId.CreateUnique(),
            category,
            brand,
            model,
            color);
    }

    public ErrorOr<ImageId> AddProductImage(string imageUrl)
    {
        var imageResult = Image.Create(imageUrl, Id);

        if (imageResult.IsError)
            return imageResult.Errors;

        _images.Add(imageResult.Value);
        return imageResult.Value.Id;
    }

    public ErrorOr<ProductSizeId> AddProductSize(SizeId sizeId, decimal price, int quantity)
    {
        var productSizessult = ProductSize.Create(Id, sizeId, price, quantity);

        if (productSizessult.IsError)
            return productSizessult.Errors;

        _productSizes.Add(productSizessult.Value);

        return productSizessult.Value.Id;
    }
}