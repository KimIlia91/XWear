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
    ProductSize ProductSize,
    string ImgUrl,
    bool IsFavorit);

public sealed record ProductSize(
    Guid Id,
    decimal Price);