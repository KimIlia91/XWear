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

    public GetProductsByCategoryQueryHandler(
        IProductRepository productRepository, 
        IMapper mapper)
    {
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<IEnumerable<ProductResult>>> Handle(
        GetProductsByCategoryQuery request, 
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var products = _productRepository.GetAllProducts();

        var updatadAtProductsByCategory = products
            .GroupBy(p => p.CategoryId)
            .Select(group => group.OrderByDescending(p => p.UpdatedAt).FirstOrDefault())
            .ToList();

        return _mapper.Map<List<ProductResult>>(updatadAtProductsByCategory);
    }
}
