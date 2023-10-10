using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.ValueObjects;

public sealed class CatalogId : ValueObject
{
    public Guid Value { get; set; }

    private CatalogId(Guid value)
    {
        Value = value;
    }

    public static CatalogId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
