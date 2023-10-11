using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Domain.Entities.UserEntity;
using XWear.Domain.Entities.UserEntity.ValueObjects;

namespace XWear.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new();

        public UserRepository()
        {
            if (_users.Count == 0)
            {
                var userResult = User.Create(
                    "Данияр",
                    "Даниярович",
                    "testuser@test.com",
                    "+996709123123",
                    "TestUser123!");

                _users.Add(userResult.Value);
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
            return _users.SingleOrDefault(u => u.Id.Value == id.Value);
        }
    }
}
