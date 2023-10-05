using Mapster;
using XWear.Domain.Entities;

namespace XWear.Application.Features.ProductContext.Common;

public class ProductResult
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string ImgUrl { get; set; } = null!;

    public decimal Price { get; set; }

    public ProductResult()
    {
        TypeAdapterConfig<Product, ProductResult>.NewConfig();
    }
}
