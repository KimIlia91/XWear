using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.BrandEntity.ValueObjects;

public sealed class BrandId : ValueObject
{
    public Guid Value { get; private set; }

    internal BrandId(Guid value)
    {
        Value = value;
    }

    public static BrandId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public static BrandId Create(Guid value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
