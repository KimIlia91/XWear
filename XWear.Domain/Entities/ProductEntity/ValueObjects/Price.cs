using ErrorOr;
using XWear.Domain.Common.Errors;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.ProductEntity.ValueObjects;

public sealed class Price : ValueObject
{
    public decimal Value { get; private set; }

    private Price(decimal value)
    {
        Value = value;
    }

    public static ErrorOr<Price> Create(decimal price)
    {
        if (price < 0)
            return Errors.Product.InvalidProductPrice;

        var priceRound = Math.Round(price, 2);

        return new Price(priceRound);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
