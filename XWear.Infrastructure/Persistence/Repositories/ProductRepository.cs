﻿using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.ProductContext.Common;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Entities.ModelEntity.ValueObjects;
using XWear.Domain.Entities.ProductSizeEntity.ValueObjects;
using XWear.Domain.Entities.UserEntity.ValueObjects;

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

    public async Task<List<ProductResult>> GetProductsByCategoryIdAsync(
        CategoryId categoryId,
        UserId userId,
        CancellationToken cancellationToken)
    {
        return await _context.Products
            .Where(p => p.CategoryId == categoryId)
            .OrderByDescending(p => p.CreatedDateTime)
            .Select(p => new ProductResult(
                p.Id.Value,
                p.Model.Name,
                p.ProductSizes.Select(ps => new ProductSizePriceResult(
                    ps.Id.Value,
                    ps.Price.Value)).First(),
                p.Images.Select(i => i.ImgUrl.Value).First(),
                p.FavoritByUsers.Any(fu => fu.Id == userId)))
            .Take(10)
            .ToListAsync(cancellationToken);
    }

    public async Task<ProductByIdResult?> GetByProductSizeIdAsync(
        ProductSizeId productSizeId, 
        CancellationToken cancellationToken)
    {
        return await _context.Products
            .Where(p => p.ProductSizes.Any(ps => ps.Id == productSizeId))
            .ProjectToType<ProductByIdResult>(_mapper.Config)
            .FirstOrDefaultAsync(cancellationToken);
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