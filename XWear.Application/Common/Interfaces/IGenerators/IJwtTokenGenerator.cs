using XWear.Domain.Entities;

namespace XWear.Application.Common.Interfaces.IGenerators
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
