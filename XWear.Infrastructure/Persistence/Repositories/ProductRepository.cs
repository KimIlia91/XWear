using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Application.Features.ProductContext.Queries.GetProductPage;
using XWear.Domain.Entities.CatalogEntity.ValueObjects;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Entities.ModelEntity.ValueObjects;
using XWear.Domain.Entities.ProductEntity;

namespace XWear.Infrastructure.Persistence.Repositories;

internal class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;

    public ProductRepository(
        ApplicationDbContext context,
        ICurrentUserService currentUserService,
        IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
        _currentUserService = currentUserService;
    }

    public Task<IEnumerable<Product>> GetAllProductsAsync(
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetFavoritUserProductsAsync(
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetProductByCatalogIdAsync(
        CatalogId catalogId, 
        CancellationToken cancellationToken)
    {
        return await _context.Products
            .Include(p => p.Model)
            .Where(p => p.Category.CatalogId == catalogId)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<ProductResult>> GetProductPageAsync(
        int pageNumber, 
        int pageSize, 
        List<string> size,
        ModelId modelId,
        ColorId colorId,
        CategoryId categoryId,
        CancellationToken cancellationToken)
    {
        var products = await _context.Products
            .Where(p => (modelId.Value == Guid.Empty || p.Model.Id == modelId) &&
                        (colorId.Value == Guid.Empty || p.Color.Id == colorId) &&
                        (categoryId.Value == Guid.Empty || p.Category.Id == categoryId) &&
                        (size.Count == 0 || size.Contains(p.Size.Name)))
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ProjectToType<ProductResult>(_mapper.Config)
            .ToListAsync(cancellationToken);

        return products;
    }
}