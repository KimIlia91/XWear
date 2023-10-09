using ErrorOr;
using MapsterMapper;
using MediatR;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetProductsByCategoryId;

public class GetProductsByCatalogIdQueryHandler
    : IRequestHandler<GetProductsByCatalogIdQuery, ErrorOr<IEnumerable<ProductResult>>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductsByCatalogIdQueryHandler(
        IProductRepository productRepository,
        IMapper mapper)
    {
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<IEnumerable<ProductResult>>> Handle(
        GetProductsByCatalogIdQuery query, 
        CancellationToken cancellationToken)
    {
        var products = await _productRepository
            .GetProductByCatalogIdAsync(query.CategoryId, cancellationToken);

        var favoritUserProducts = await _productRepository
            .GetFavoritUserProductsAsync(cancellationToken);

        var productResults = _mapper.Map<List<ProductResult>>(products);

        if (favoritUserProducts.Any())
        {
            foreach (var productResult in productResults)
            {
                productResult.IsFavorit = favoritUserProducts.Any(p => p.Id == productResult.Id);
            }
        }

        return productResults;
    }
}
