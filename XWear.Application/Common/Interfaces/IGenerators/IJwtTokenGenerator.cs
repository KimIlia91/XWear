using XWear.Domain.Catalog.Entities.UserEntity;

namespace XWear.Application.Common.Interfaces.IGenerators
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
