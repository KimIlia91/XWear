using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.BrandEntity.ValueObjects;
using XWear.Domain.Common.Constants;
using ErrorOr;
using XWear.Domain.Common.Errors;

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

    public static ErrorOr<Brand> Create(string name)
    {
        if (string.IsNullOrEmpty(name) || name.Length > EntityConstants.BrandNameLength)
            return Errors.Brand.InvalidNameLength;

        return new Brand(BrandId.CreateUnique(), name);
    }
}
