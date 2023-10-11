using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.CatalogEntity.ValueObjects;

public sealed class CatalogId : ValueObject
{
    public Guid Value { get; private set; }

    private CatalogId(Guid value)
    {
        Value = value;
    }

    public static CatalogId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public static CatalogId Create(Guid value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
