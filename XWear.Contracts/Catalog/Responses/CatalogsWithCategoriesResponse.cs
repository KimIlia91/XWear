namespace XWear.Contracts.Catalog.Responses;

public sealed record CatalogsWithCategoriesResponse(
    Guid Id,
    string Name,
    IEnumerable<CatalogCategoryResponse> Categories);

public sealed record CatalogCategoryResponse(
    Guid Id,
    string Name);