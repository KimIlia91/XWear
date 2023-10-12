using XWear.Domain.Entities.ProductEntity.ValueObjects;
using XWear.Domain.Entities.UserEntity;
using XWear.Domain.Entities.UserEntity.ValueObjects;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface IUserRepository
{
    Task<User?> GetUserByEmailAsync(
        string email, 
        CancellationToken cancellationToken);

    Task<User?> GetUserByIdAsync(
        UserId id, 
        CancellationToken cancellationToken);

    Task AddAsync(
        User user, 
        CancellationToken cancellationToken);

    Task<User?> GetUserWithTrackableFavoritProductByIdAsync(
         UserId id,
         CancellationToken cancellationToken);
}
