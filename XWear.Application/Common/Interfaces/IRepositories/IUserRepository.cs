using XWear.Domain.Catalog.Entities;

namespace XWear.Application.Common.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);

        User? GetUserById(Guid id);

        void Add(User user);
    }
}
