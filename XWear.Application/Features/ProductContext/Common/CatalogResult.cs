namespace XWear.Application.Features.ProductContext.Common;

public class CatalogResult
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public IEnumerable<CategoryResult> Categories { get; set; } = null!;
}