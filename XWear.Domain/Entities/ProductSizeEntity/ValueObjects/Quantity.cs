using ErrorOr;
using XWear.Domain.Common.Errors;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.ProductSizeEntity.ValueObjects;

public sealed class Quantity : ValueObject
{
    public int Value { get; private set; }

    private Quantity(
        int value)
    {
        Value = value;
    }

    public static ErrorOr<Quantity> Create(int value)
    {
        if (value < 0)
            return Errors.Product.InvalidQuantity;

        return new Quantity(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
