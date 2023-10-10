using XWear.Domain.Common.Models;

namespace XWear.Domain.EntitiesCatalog.Entities.ColorEntity.ValueObjects;

public sealed class ColorId : ValueObject
{
    public Guid Value { get; private set; }

    private ColorId(Guid value)
    {
        Value = value;
    }

    public static ColorId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
