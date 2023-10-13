using XWear.Contracts.Catalog.Responses;

namespace XWear.Contracts.Product.Responses;

public sealed record ProductResponse(
    Guid Id,
    string Name,
    ProductPriceResponse ProductSize,
    string ImgUrl,
    bool IsFavorit);

public sealed record ProductPriceResponse(
    Guid Id,
    decimal Price);