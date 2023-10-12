using ErrorOr;
using MediatR;
using XWear.Domain.Common.Errors;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Domain.Entities.ProductEntity;
using XWear.Application.Features.FavoritProductContext.Common;

namespace XWear.Application.Features.FavoritProductContext.Commands.AddFavoritProduct;

internal sealed class AddFavoritPoductCommandHandler
    : IRequestHandler<AddFavoritPoductCommand, ErrorOr<AddProductToFavoritsResult>>
{
    private readonly IUserRepository _userRepository;
    private readonly ICurrentUserService _currentUser;
    private readonly IBaseRepository<Product> _baseRepository;

    public AddFavoritPoductCommandHandler(
        IUserRepository userRepository,
        ICurrentUserService currentUser,
        IBaseRepository<Product> baseRepository)
    {
        _baseRepository = baseRepository;
        _userRepository = userRepository;
        _currentUser = currentUser;
    }

    public async Task<ErrorOr<AddProductToFavoritsResult>> Handle(
        AddFavoritPoductCommand command,
        CancellationToken cancellationToken)
    {
        var user = await _userRepository
            .GetUserWithTrackableFavoritProductByIdAsync(_currentUser.UserId, cancellationToken);

        if (user is null)
            return Errors.Authentication.InvalidCredentinals;

        var productId = ProductId.Create(command.ProdcutId);
        var product = await _baseRepository
            .GetOrDeafaultAsync(p => p.Id == productId, cancellationToken);

        if (product is null)
            return Errors.Product.NotFound;

        user.AddFavoriteProducts(product);
        await _baseRepository.SaveChangesAsync(cancellationToken);
        return new AddProductToFavoritsResult(product.Id.Value);
    }
}