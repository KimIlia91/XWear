using ErrorOr;
using MediatR;
using MapsterMapper;
using XWear.Domain.Entities;
using XWear.Domain.Common.Errors;
using XWear.Application.Common.Interfaces;
using XWear.Application.Features.Account.Common;

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
        await Task.CompletedTask;

        var user = _userRepository.GetUserByEmail(command.Email);

        if (user is not null && user.Id != _currentUser.UserId)
            return Errors.User.DuplicateEmail;

        user ??= _userRepository.GetUserById(_currentUser.UserId);

        if (user is null)
            return Errors.Authentication.InvalidCredentinals;

        _mapper.Map(command, user);

        return _mapper.Map<AccountResult>(user);
    }
}
