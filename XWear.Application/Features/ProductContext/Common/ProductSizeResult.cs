using Mapster;
using XWear.Domain.Entities;

namespace XWear.Application.Features.ProductContext.Common;

public class ProductSizeResult : IRegister
{
    public string Size { get; set; } = null!;

    public decimal Price { get; set; }

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<ProductSize, ProductSizeResult>()
           .Map(dest => dest.Size, src => src.Size.Name)
           .Map(dest => dest.Price, src => src.Price);
    }
}