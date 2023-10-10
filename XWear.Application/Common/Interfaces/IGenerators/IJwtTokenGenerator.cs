using XWear.Domain.Catalog.Entities;

namespace XWear.Application.Common.Interfaces.IGenerators
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
