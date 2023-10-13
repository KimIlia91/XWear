using ErrorOr;
using MediatR;
using MapsterMapper;
using XWear.Application.Common.Resources;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.ProductContext.Common;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Entities.ProductSizeEntity.ValueObjects;

namespace XWear.Application.Features.ProductContext.Queries.GetByProductSizeId;

internal sealed class GetByProductSizeIdQueryHandler
    : IRequestHandler<GetByProductSizeIdQuery, ErrorOr<ProductByIdResult>>
{
    private readonly IProductRepository _productRepository;

    public GetByProductSizeIdQueryHandler(
        IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<ProductByIdResult>> Handle(
        GetByProductSizeIdQuery query,
        CancellationToken cancellationToken)
    {
        var productId = ProductSizeId.Create(query.ProductSizeId);
        var productResult = await _productRepository
            .GetByProductSizeIdAsync(productId, cancellationToken);

        if (productResult is null)
            return Error.NotFound(ErrorResources.NotFound, nameof(ProductId));

        foreach (var productSize in productResult.ProductSizes)
            productSize.IsSelected = productSize.Id == query.ProductSizeId;

        if (!productResult.ProductSizes.Any(ps => ps.IsSelected))
            return Error.NotFound(ErrorResources.NotFound, nameof(ProductSizeId));

        return productResult;
    }
}
