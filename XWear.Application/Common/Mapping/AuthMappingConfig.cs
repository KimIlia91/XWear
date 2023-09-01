using Mapster;
using XWear.Application.Authentication.Common;
using XWear.Contracts.Authetication;

namespace XWear.Application.Common.Mapping
{
    public class AuthMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<AuthenticationResult, AuthenticationResponse>();
        }
    }
}
