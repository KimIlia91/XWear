using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.ProductContext.Common;
using XWear.Application.Features.ProductContext.Queries.GetProductPage;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Entities.ModelEntity.ValueObjects;

namespace XWear.Infrastructure.Persistence.Repositories;

internal class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public ProductRepository(
        ApplicationDbContext context,
        IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<ProductByIdResult?> GetProductByIdAsync(
        Guid productId, 
        CancellationToken cancellationToken)
    {
        return await _context.Products
            .ProjectToType<ProductByIdResult>(_mapper.Config)
            .FirstOrDefaultAsync(p => p.Id == productId, cancellationToken);
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
        //var products = await _context.Products
        //    .Where(p => (modelId.Value == Guid.Empty || p.Model.Id == modelId) &&
        //                (colorId.Value == Guid.Empty || p.Color.Id == colorId) &&
        //                (categoryId.Value == Guid.Empty || p.Category.Id == categoryId) &&
        //                (size.Count == 0 || size.Contains(p.Size.Name)))
        //    .Skip((pageNumber - 1) * pageSize)
        //    .Take(pageSize)
        //    .ProjectToType<ProductResult>(_mapper.Config)
        //    .ToListAsync(cancellationToken);
        //
        //return products;
        return new List<ProductResult>();
    }
}