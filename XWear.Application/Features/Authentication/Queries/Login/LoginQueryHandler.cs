using ErrorOr;
using MediatR;
using XWear.Domain.Common.Errors;
using XWear.Application.Features.Authentication.Common;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IGenerators;
using XWear.Domain.Catalog.Entities;

namespace XWear.Application.Features.Authentication.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(
        IUserRepository userRepository,
        IJwtTokenGenerator jwtTokenGenerator)
    {
        _userRepository = userRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(
    LoginQuery query,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        if (_userRepository.GetUserByEmail(query.Email) is not User user)
            return Errors.Authentication.InvalidCredentinals;

        if (user.Password != query.Password)
            return Errors.Authentication.InvalidCredentinals;

        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user.Email, token, token);
    }
}
