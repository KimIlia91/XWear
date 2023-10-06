using ErrorOr;
using MapsterMapper;
using MediatR;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetProducts;

public class GetProductsByCategoryQueryHandler
    : IRequestHandler<GetProductsByCategoryQuery, ErrorOr<IEnumerable<ProductResult>>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    private readonly ICatalogRepository _catalogRepository;

    public GetProductsByCategoryQueryHandler(
        IProductRepository productRepository, 
        IMapper mapper,
        ICatalogRepository catalogRepository)
    {
        _catalogRepository = catalogRepository;
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<IEnumerable<ProductResult>>> Handle(
        GetProductsByCategoryQuery request, 
        CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAllProductsAsync(cancellationToken);

        return _mapper.Map<List<ProductResult>>(products.ToList());
    }
}
