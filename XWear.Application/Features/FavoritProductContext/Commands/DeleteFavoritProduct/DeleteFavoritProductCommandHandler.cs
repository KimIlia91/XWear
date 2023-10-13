using ErrorOr;
using MediatR;
using XWear.Domain.Common.Errors;
using XWear.Domain.Entities.ProductEntity;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.FavoritProductContext.Common;

namespace XWear.Application.Features.FavoritProductContext.Commands.DeleteFavoritProduct;

internal sealed class DeleteFavoritProductCommandHandler
    : IRequestHandler<DeleteFavoritProductCommand, ErrorOr<DeleteFavoritProductResult>>
{
    private readonly IUserRepository _userRepository;
    private readonly ICurrentUserService _currentUser;
    private readonly IBaseRepository<Product> _baseRepository;

    public DeleteFavoritProductCommandHandler(
        IUserRepository userRepository,
        ICurrentUserService currentUser,
        IBaseRepository<Product> baseRepository)
    {
        _userRepository = userRepository;
        _currentUser = currentUser;
        _baseRepository = baseRepository;
    }

    public async Task<ErrorOr<DeleteFavoritProductResult>> Handle(
        DeleteFavoritProductCommand command, 
        CancellationToken cancellationToken)
    {
        var user = await _userRepository
            .GetUserWithTrackableFavoritProductByIdAsync(_currentUser.UserId, cancellationToken);

        if (user is null)
            return Errors.Authentication.InvalidCredentinals;

        var productId = ProductId.Create(command.ProductId);
        var product = await _baseRepository
            .GetOrDeafaultAsync(p => p.Id == productId, cancellationToken);

        if (product is null)
            return Errors.Product.NotFound;

        user.DeleteFromFavoriteProducts(product);
        await _baseRepository.SaveChangesAsync(cancellationToken);
        return new DeleteFavoritProductResult(product.Id.Value);
    }
}
