using ErrorOr;
using MapsterMapper;
using MediatR;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Application.Features.ProductContext.Common;
using XWear.Domain.Entities;

namespace XWear.Application.Features.ProductContext.Commands.AddFavoritProductCommand;

public class AddProductToFavoriteCommandHandler
    : IRequestHandler<AddProductToFavoriteCommand, ErrorOr<AddedFavoritProductResult>>
{
    private readonly IProductRepository _productRepository;
    private readonly ICurrentUserService _currentUserService;
    private readonly IMapper _mapper;

    public AddProductToFavoriteCommandHandler(
        IProductRepository productRepository,
        ICurrentUserService currentUserService, 
        IMapper mapper)
    {
        _currentUserService = currentUserService;
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ErrorOr<AddedFavoritProductResult>> Handle(
        AddProductToFavoriteCommand command,
        CancellationToken cancellationToken)
    {
        var favoriteProduct = new FavoritProduct()
        {
            UserId = _currentUserService.UserId,
            ProductId = command.ProductId,
        };

        var addedFavoriteProduct = await _productRepository
            .AddFavoriteProductAsync(favoriteProduct, cancellationToken);

        return _mapper.Map<AddedFavoritProductResult>(addedFavoriteProduct);
    }
}
