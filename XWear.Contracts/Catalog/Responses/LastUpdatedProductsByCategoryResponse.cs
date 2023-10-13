using XWear.Contracts.Product.Responses;

namespace XWear.Contracts.Catalog.Responses;

public sealed record LastUpdatedProductsByCategoryResponse(
    Guid Id,
    string Name,
    IEnumerable<CategoryResponse> Categories);

public sealed record CategoryResponse(
    string Name,
    ProductResponse Product);

public sealed record ProductResponse(
    Guid Id,
    string Name,
    ProductPriceResponse ProductSize,
    string ImgUrl,
    bool IsFavorit);

public sealed record ProductPriceResponse(
    Guid Id,
    decimal Price);