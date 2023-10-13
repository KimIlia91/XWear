using ErrorOr;
using MediatR;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Application.Features.ProductContext.Common;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;

namespace XWear.Application.Features.ProductContext.Queries.GetProductsByCategorId;

internal sealed class GetProductsByCategorIdQueryHandler
    : IRequestHandler<GetProductsByCategorIdQuery, ErrorOr<List<ProductResult>>>
{
    private readonly IProductRepository _productRepository;
    private readonly ICurrentUserService _currentUser;

    public GetProductsByCategorIdQueryHandler(
        IProductRepository productRepository,
        ICurrentUserService currentUser)
    {
        _currentUser = currentUser;
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<List<ProductResult>>> Handle(
        GetProductsByCategorIdQuery query,
        CancellationToken cancellationToken)
    {
        var catergoryId = CategoryId.Create(query.CategoryId);
        var products = await _productRepository
            .GetProductsByCategoryIdAsync(catergoryId, _currentUser.UserId, cancellationToken);

        return products;
    }
}
