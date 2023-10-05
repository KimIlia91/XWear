using ErrorOr;
using MapsterMapper;
using MediatR;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetProducts;

public class GetProductsQueryHandler
    : IRequestHandler<GetProductsQuery, ErrorOr<IEnumerable<ProductResult>>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductsQueryHandler(
        IProductRepository productRepository, 
        IMapper mapper)
    {
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<IEnumerable<ProductResult>>> Handle(
        GetProductsQuery request, 
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var products = _productRepository.GetAllProducts();
        return _mapper.Map<List<ProductResult>>(products);
    }
}
