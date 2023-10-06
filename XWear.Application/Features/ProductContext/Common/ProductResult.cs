using Mapster;
using XWear.Domain.Entities;

namespace XWear.Application.Features.ProductContext.Common;

public class ProductResult : IRegister
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string ImgUrl { get; set; } = null!;

    public IEnumerable<ProductSizeResult> Prices { get; set; } = new List<ProductSizeResult>();

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Product, ProductResult>()
         .Map(dest => dest.Name, src => src.Model.Name)
         .Map(dest => dest.Prices, src => src.ProductSizes);
    }
}