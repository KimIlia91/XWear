using XWear.Domain.Common.Models;
using XWear.Domain.Entities.FavoritParoductEntity;
using XWear.Domain.Entities.SizeEntity.ValueObjects;
using XWear.Domain.Entities.UserEntity.ValueObjects;
using XWear.Domain.Entities.BrandEntity.ValueObjects;
using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Entities.ModelEntity.ValueObjects;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Entities.FavoritParoductEntity.ValueObjects;

namespace XWear.Domain.Entities.ProductEntity;

public sealed class Product : AggregateRoot<ProductId>
{
    private readonly List<FavoritProduct> _favoritProducts = new();

    public decimal Price { get; private set; }

    public int Quantity { get; private set; }

    public string ImgUrl { get; private set; } = null!;

    public DateTime CreatedDateTime { get; private set; }

    public DateTime UpdatedDateTime { get; private set; }

    public CategoryId CategoryId { get; private set; }

    public SizeId SizeId { get; private set; }

    public ColorId ColorId { get; private set; }

    public BrandId BrandId { get; private set; }

    public ModelId ModelId { get; private set; }

    public IReadOnlyList<FavoritProduct> FavoritProducts => _favoritProducts.AsReadOnly();

    internal Product(
        ProductId productId,
        decimal price,
        int quantity,
        string imgUrl,
        CategoryId categoryId,
        BrandId brandId,
        ModelId modelId,
        SizeId sizeId,
        ColorId colorId)
        : base(productId)
    {
        Price = price;
        Quantity = quantity;
        ImgUrl = imgUrl;
        CreatedDateTime = DateTime.UtcNow;
        UpdatedDateTime = DateTime.UtcNow;
        CategoryId = categoryId;
        BrandId = brandId;
        ModelId = modelId;
        ColorId = colorId;
        SizeId = sizeId;
    }

    public static Product Create(
        decimal price,
        int quantity,
        string imgUrl,
        CategoryId categoryId,
        BrandId brandId,
        ModelId modelId,
        SizeId sizeId,
        ColorId colorId)
    {
        return new(
            ProductId.CreateUnique(),
            price,
            quantity,
            imgUrl,
            categoryId,
            brandId,
            modelId,
            sizeId,
            colorId);
    }

    public FavoriteProductId AddFavoritProduct(
        UserId userId,
        ProductId productId)
    {
        var favoritProduct = new FavoritProduct(userId, productId);
        _favoritProducts.Add(favoritProduct);
        return favoritProduct.Id;
    }
}