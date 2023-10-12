using ErrorOr;
using MediatR;
using XWear.Domain.Common.Errors;
using XWear.Domain.Entities.UserEntity;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Domain.Entities.ProductEntity;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Commands.AddPoductToFavorits;

internal sealed class AddPoductToFavoritsCommandHandler
    : IRequestHandler<AddPoductToFavoritsCommand, ErrorOr<AddProductToFavoritsResult>>
{
    private readonly IUserRepository _userRepository;
    private readonly ICurrentUserService _currentUser;
    private readonly IBaseRepository<Product> _baseRepository;

    public AddPoductToFavoritsCommandHandler(
        IUserRepository userRepository,
        ICurrentUserService currentUser,
        IBaseRepository<Product> baseRepository)
    {
        _baseRepository = baseRepository;
        _userRepository = userRepository;
        _currentUser = currentUser;
    }

    public async Task<ErrorOr<AddProductToFavoritsResult>> Handle(
        AddPoductToFavoritsCommand command, 
        CancellationToken cancellationToken)
    {
        if (_userRepository.GetUserById(_currentUser.UserId) is not User user)
            return Errors.Authentication.InvalidCredentinals;

        var productId = ProductId.Create(command.ProdcutId);
        var product = await _baseRepository
            .GetEntityOrDeafaultAsync(p => p.Id == productId, cancellationToken);

        if (product is null)
            return Errors.Product.NotFound;

        product.AddToFavorits(user);
        await _baseRepository.SaveChangesAsync(cancellationToken);
        return new AddProductToFavoritsResult(product.Id.Value);
    }
}