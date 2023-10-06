using Mapster;
using XWear.Contracts.Product.Responses;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Common.Mapping.Products;

public class ProductMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CategoryResult, CategoryResponse>();

        config.NewConfig<CatalogResponse, CatalogResult>();

        config.NewConfig<ProductResult, ProductResponse>();
    }
}
