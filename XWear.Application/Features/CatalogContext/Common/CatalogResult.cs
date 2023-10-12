namespace XWear.Application.Features.CatalogContext.Common;

public sealed record CatalogResult(
    Guid Id,
    string Name,
    IEnumerable<CategoryResult> Categories);

public sealed record CategoryResult(
    IEnumerable<ProductResult> Products);

public sealed record ProductResult(
    Guid Id,
    string Name,
    decimal Price,
    string ImgUrl,
    bool IsFavorit);