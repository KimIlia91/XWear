using ErrorOr;
using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Entities.ProductSizeEntity.ValueObjects;
using XWear.Domain.Entities.SizeEntity.ValueObjects;

namespace XWear.Domain.Entities.ProductSizeEntity;

public sealed class ProductSize : Entity<ProductSizeId>
{
    public ProductId ProductId { get; private set; }

    public SizeId SizeId { get; private set; }

    public Price Price { get; private set; }

    public Quantity Quantity { get; private set; }

    private ProductSize() : base(ProductSizeId.CreateUnique())
    {
    }

    private ProductSize(
        ProductSizeId id,
        ProductId productId,
        SizeId sizeId,
        Quantity quantity,
        Price price) 
        : base(id)
    {
        Id = id;
        ProductId = productId;
        SizeId = sizeId;
        Price = price;
        Quantity = quantity;
    }

    public static ErrorOr<ProductSize> Create(
        ProductId productId,
        SizeId sizeId,
        decimal price,
        int quantity)
    {
        var priceResult = Price.Create(price);

        if (priceResult.IsError)
            return priceResult.Errors;

        var quantityResult = Quantity.Create(quantity);

        if (quantityResult.IsError)
            return quantityResult.Errors;

        return new ProductSize(
            ProductSizeId.CreateUnique(),
            productId,
            sizeId,
            quantityResult.Value,
            priceResult.Value);
    }
}
