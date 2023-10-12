using Microsoft.EntityFrameworkCore;
using XWear.Domain.Entities.UserEntity;
using XWear.Domain.Entities.UserEntity.ValueObjects;
using XWear.Application.Common.Interfaces.IRepositories;

namespace XWear.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(
            User user, 
            CancellationToken cancellationToken)
        {
            await _context.Users
                .AddAsync(user, cancellationToken);
        }

        public async Task<User?> GetUserByEmailAsync(
            string email, 
            CancellationToken cancellationToken)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
        }

        public async Task<User?> GetUserByIdAsync(
            UserId id, 
            CancellationToken cancellationToken)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Id.Value == id.Value, cancellationToken);
        }
    }
}
