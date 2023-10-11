using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.ColorEntity.ValueObjects;

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

    public static ColorId CreateEmpty()
    {
        return new(Guid.Empty);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
