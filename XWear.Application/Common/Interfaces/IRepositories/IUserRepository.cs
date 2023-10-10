using XWear.Domain.Catalog.Entities;
using XWear.Domain.Catalog.ValueObjects;

namespace XWear.Application.Common.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);

        User? GetUserById(UserId id);

        void Add(User user);
    }
}
