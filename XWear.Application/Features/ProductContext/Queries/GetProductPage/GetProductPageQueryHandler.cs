using ErrorOr;
using MediatR;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetProductPage
{
    public sealed class GetProductPageQueryHandler
        : IRequestHandler<GetProductPageQuery, ErrorOr<IEnumerable<ProductResult>>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductPageQueryHandler(
            IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ErrorOr<IEnumerable<ProductResult>>> Handle(
            GetProductPageQuery query,
            CancellationToken cancellationToken)
        {
            var products = await _productRepository
                .GetProductPageAsync(
                query.Filter.Page, 
                query.Filter.PageSize, 
                query.Filter.Sizes, 
                query.Filter.ModelId, 
                query.Filter.ColorId,
                query.Filter.CategoryId, 
                cancellationToken);

            return products.ToList();
        }
    }
}
