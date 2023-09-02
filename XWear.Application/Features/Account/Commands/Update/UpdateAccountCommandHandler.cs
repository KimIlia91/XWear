using ErrorOr;
using MediatR;
using XWear.Domain.Entities;
using XWear.Domain.Common.Errors;
using XWear.Application.Common.Resources;
using XWear.Application.Common.Interfaces;

namespace XWear.Application.Features.Account.Commands.Update;

public class UpdateAccountCommandHandler
    : IRequestHandler<UpdateAccountCommand, ErrorOr<string>>
{
    private readonly ICurrentUserService _currentUser;
    private readonly IUserRepository _userRepository;

    public UpdateAccountCommandHandler(
        ICurrentUserService currentUser,
        IUserRepository userRepository)
    {
        _currentUser = currentUser;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<string>> Handle(
        UpdateAccountCommand command,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        if (_userRepository.GetUserById(_currentUser.UserId) is not User user)
            return Errors.Authentication.InvalidCredentinals;

        user.LastName = command.LastName;
        user.FirstName = command.FirstName;
        user.Email = command.Email;
        user.Phone = command.Phone;

        return SuccessResources.UserUpdated;
    }
}
