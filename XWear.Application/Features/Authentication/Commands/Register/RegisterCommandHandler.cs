using ErrorOr;
using MediatR;
using MapsterMapper;
using XWear.Domain.Common.Errors;
using XWear.Application.Features.Authentication.Common;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IGenerators;
using XWear.Domain.EntitiesCatalog.UserEntity;

namespace XWear.Application.Features.Authentication.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public RegisterCommandHandler(
        IUserRepository userRepository,
        IJwtTokenGenerator jwtTokenGenerator, 
        IMapper mapper)
    {
        _userRepository = userRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
        _mapper = mapper;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(
        RegisterCommand command,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        if (_userRepository.GetUserByEmail(command.Email) is not null)
            return Errors.User.DuplicateEmail;

        if (!string.Equals(command.Password, command.ConfirmPassword))
            return Errors.Authentication.InvalidConfirmPassword;

        var user = _mapper.Map<User>(command);

        _userRepository.Add(user);
        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user.Email, token, token);
    }
}
