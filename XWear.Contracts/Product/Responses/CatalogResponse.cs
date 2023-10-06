namespace XWear.Contracts.Product.Responses
{
    public record CatalogResponse(
        Guid Id,
        string Name,
        IEnumerable<CategoryResponse> Categories);
}
