using XWear.Domain.Catalog.Entities.BrandEntity.ValueObjects;
using XWear.Domain.Catalog.Entities.ProductEntity;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.Entities.BrandEntity;

public sealed class Brand : Entity<BrandId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public IReadOnlyList<Product> Products => _products.AsReadOnly();

    internal Brand(
        BrandId brandId,
        string name)
        : base(brandId)
    {
        Name = name;
    }

    public static Brand Create(string name)
    {
        return new(BrandId.CreateUnique(), name);
    }
}
