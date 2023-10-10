using XWear.Domain.Entities.UserEntity;

namespace XWear.Application.Common.Interfaces.IGenerators
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
