using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.BrandEntity.ValueObjects;

namespace XWear.Domain.Entities.BrandEntity;

public sealed class Brand : Entity<BrandId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public IReadOnlyCollection<Product> Products => _products.AsReadOnly();

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
