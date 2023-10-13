using ErrorOr;
using MediatR;
using MapsterMapper;
using XWear.Application.Common.Resources;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.ProductContext.Common;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Entities.ProductSizeEntity.ValueObjects;

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
        var productResult = await _productRepository
            .GetProductByIdAsync(productId, cancellationToken);

        if (productResult is null)
            return Error.NotFound(nameof(ProductId), ErrorResources.NotFound);

        foreach (var productSize in productResult.ProductSizes)
            productSize.IsSelected = productSize.Id == query.ProductSizeId;

        if (!productResult.ProductSizes.Any(ps => ps.IsSelected))
            return Error.NotFound(nameof(ProductSizeId), ErrorResources.NotFound);

        return productResult;
    }
}
