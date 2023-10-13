using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.CatalogContext.Common;

public sealed record CatalogResult(
    Guid Id,
    string Name,
    IEnumerable<CategoryResult> Categories);

public sealed record CategoryResult(
    Guid Id,
    string Name,
    ProductResult? Product);