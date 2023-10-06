using ErrorOr;
using MediatR;
using MapsterMapper;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetProducts;

public class GetProductsByCategoryQueryHandler
    : IRequestHandler<GetProductsByCategoryQuery, ErrorOr<IEnumerable<CatalogResult>>>
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

    public async Task<ErrorOr<IEnumerable<CatalogResult>>> Handle(
        GetProductsByCategoryQuery request,
        CancellationToken cancellationToken)
    {
        var catalogs = await _catalogRepository.GetCatalogsAsync(cancellationToken);
        var catalogResult = catalogs
            .Select(c => new CatalogResult()
            {
                Id = c.Id,
                Name = c.Name,
                Categories = c.Categories.Select(c => new CategoryResult()
                {
                    Name = c.Name,
                    Products = c.Products.OrderByDescending(p => p.UpdatedAt)
                    .Select(p => new ProductResult()
                    {
                        Id = p.Id,
                        ImgUrl = p.ImgUrl ?? string.Empty,
                        Model = p.Model != null ? p.Model.Name : string.Empty,
                        Price = p.Price,
                    }).FirstOrDefault() ?? new ProductResult()
                })
            })
            .ToList();

        return catalogResult;
    }
}
