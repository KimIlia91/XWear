using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Domain.Catalog.Entities;
using XWear.Domain.Catalog.ValueObjects;

namespace XWear.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new();

        public UserRepository()
        {
            if (_users.Count == 0)
            {
                _users.Add(User.Create(
                    "Данияр",
                    "Даниярович",
                    "testuser@test.com",
                    "+996709123123",
                    "TestUser123!"));
            }
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User? GetUserByEmail(string email)
        {
            return _users.SingleOrDefault(u => u.Email == email);
        }

        public User? GetUserById(UserId id)
        {
            return _users.SingleOrDefault(u => u.Id == id);
        }
    }
}
