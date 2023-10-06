using Mapster;
using XWear.Domain.Entities;

namespace XWear.Application.Features.ProductContext.Common;

public class CategoryResult : IRegister
{
    public string Name { get; set; } = null!;

    public ProductResult Products { get; set; } = new();

    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Category, CategoryResult>()
            .Map(dest => dest.Products, src => src.Products);
    }
}
