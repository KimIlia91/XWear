using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.ProductEntity.ValueObjects;

public sealed class Price : ValueObject
{
    public decimal Value { get; private set; }

    private Price(decimal value)
    {
        Value = value;
    }

    public static Price Create(decimal price)
    {
        var priceRound = Math.Round(price, 2);

        return new(priceRound);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
