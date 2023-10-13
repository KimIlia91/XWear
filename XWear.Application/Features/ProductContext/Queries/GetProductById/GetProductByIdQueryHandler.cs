using ErrorOr;
using MapsterMapper;
using MediatR;
using XWear.Domain.Common.Errors;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.ProductContext.Common;
using XWear.Domain.Entities.ProductEntity.ValueObjects;

namespace XWear.Application.Features.ProductContext.Queries.GetProductById;

internal sealed class GetProductByIdQueryHandler 
    : IRequestHandler<GetProductByIdQuery, ErrorOr<ProductByIdResult>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductByIdQueryHandler(
        IProductRepository productRepository,
        IMapper mapper)
    {
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<ProductByIdResult>> Handle(
        GetProductByIdQuery query, 
        CancellationToken cancellationToken)
    {
        var productId = ProductId.Create(query.Id);
        var product = await _productRepository
            .GetProductByIdAsync(productId, cancellationToken);

        if (product is null)
            return Errors.Product.NotFound;

        var productResult = _mapper.Map<ProductByIdResult>(product);
        productResult.ProductSizes = product.ProductSizes.Select(ps => new ProductSizeResult()
        {
            Id = ps.Id.Value,
            Price = ps.Price.Value,
            IsSelected = ps.Id.Value == query.ProductSizeId
        });

        return productResult;
    }
}
