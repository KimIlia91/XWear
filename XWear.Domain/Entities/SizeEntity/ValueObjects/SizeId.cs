using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.SizeEntity.ValueObjects;

public sealed class SizeId : ValueObject
{
    public Guid Value { get; private set; }

    private SizeId(Guid value)
    {
        Value = value;
    }

    public static SizeId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public static SizeId Create(Guid value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
