namespace XWear.Application.Features.CatalogContext.Common;

public sealed record CatalogResult(
    Guid Id,
    string Name,
    IEnumerable<CategoryResult> Categories);

public sealed record CategoryResult(
    string Name,
    ProductResult? Product);

public sealed record ProductResult(
    Guid Id,
    string Name,
    ProductSizePriceResult ProductSize,
    string ImgUrl,
    bool IsFavorit);

public sealed record ProductSizePriceResult(
    Guid Id,
    decimal Price);