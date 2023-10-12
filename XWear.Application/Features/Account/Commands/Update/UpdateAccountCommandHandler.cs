using ErrorOr;
using MapsterMapper;
using MediatR;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Application.Features.Account.Common;
using XWear.Domain.Common.Errors;

namespace XWear.Application.Features.Account.Commands.Update;

public class UpdateAccountCommandHandler
    : IRequestHandler<UpdateAccountCommand, ErrorOr<AccountResult>>
{
    private readonly ICurrentUserService _currentUser;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UpdateAccountCommandHandler(
        ICurrentUserService currentUser,
        IUserRepository userRepository,
        IMapper mapper)
    {
        _currentUser = currentUser;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<ErrorOr<AccountResult>> Handle(
        UpdateAccountCommand command,
        CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserByEmailAsync(command.Email, cancellationToken);

        if (user is not null && user.Id != _currentUser.UserId)
            return Errors.User.DuplicateEmail;

        user ??= await _userRepository.GetUserByIdAsync(_currentUser.UserId, cancellationToken);

        if (user is null)
            return Errors.Authentication.InvalidCredentinals;

        _mapper.Map(command, user);

        return _mapper.Map<AccountResult>(user);
    }
}
