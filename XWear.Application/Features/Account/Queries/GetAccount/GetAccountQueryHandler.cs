using ErrorOr;
using MediatR;
using MapsterMapper;
using XWear.Domain.Common.Errors;
using XWear.Application.Features.Account.Common;
using XWear.Application.Common.Interfaces.IServices;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Domain.EntitiesCatalog.Entities.UserEntity;
using XWear.Domain.EntitiesCatalog.Entities.CategoryEntity;
using XWear.Domain.EntitiesCatalog.Entities.CatalogEntity;
using XWear.Domain.EntitiesCatalog.Entities.CatalogEntity.ValueObjects;

namespace XWear.Application.Features.Account.Queries.GetAccount;

public class GetAccountQueryHandler 
    : IRequestHandler<GetAccountQuery, ErrorOr<AccountResult>>
{
    private readonly ICurrentUserService _currentUser;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetAccountQueryHandler(
        ICurrentUserService currentUser,
        IUserRepository userRepository,
        IMapper mapper)
    {
        _currentUser = currentUser;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<ErrorOr<AccountResult>> Handle(
        GetAccountQuery request, 
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        if (_userRepository.GetUserById(_currentUser.UserId) is not User user)
            return Errors.Authentication.InvalidCredentinals;
        return _mapper.Map<AccountResult>(user);
    }
}
