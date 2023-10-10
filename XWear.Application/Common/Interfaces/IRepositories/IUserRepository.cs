using XWear.Domain.EntitiesCatalog.UserEntity;
using XWear.Domain.EntitiesCatalog.UserEntity.ValueObjects;

namespace XWear.Application.Common.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);

        User? GetUserById(UserId id);

        void Add(User user);
    }
}
