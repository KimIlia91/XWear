using XWear.Domain.Catalog.ValueObjects;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.Entities;

public sealed class Brand : Entity<BrandId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public IReadOnlyList<Product> Products => _products.AsReadOnly();

    public Brand(
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
