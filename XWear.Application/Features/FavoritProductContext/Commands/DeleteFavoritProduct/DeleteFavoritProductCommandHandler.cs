using ErrorOr;
using MediatR;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Contracts.FavoritProduct.Responses;
using XWear.Domain.Common.Errors;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.ProductEntity.ValueObjects;

namespace XWear.Application.Features.FavoritProductContext.Commands.DeleteFavoritProduct;

internal sealed class DeleteFavoritProductCommandHandler
    : IRequestHandler<DeleteFavoritProductCommand, ErrorOr<DeleteFavoritProductResponse>>
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

    public async Task<ErrorOr<DeleteFavoritProductResponse>> Handle(
        DeleteFavoritProductCommand command, 
        CancellationToken cancellationToken)
    {
        var productId = ProductId.Create(command.ProductId);
        var user = await _userRepository
            .GetUserWithFavoritProductByIdAsync(productId, _currentUser.UserId, cancellationToken);

        if (user is null)
            return Errors.Authentication.InvalidCredentinals;

        var product = await _baseRepository
            .GetOrDeafaultAsync(p => p.Id == productId, cancellationToken);

        if (product is null)
            return Errors.Product.NotFound;

        user.DeleteFromFavoriteProducts(product);
        await _baseRepository.SaveChangesAsync(cancellationToken);
        return new DeleteFavoritProductResponse(product.Id.Value);
    }
}
