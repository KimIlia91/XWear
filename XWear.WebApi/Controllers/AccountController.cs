using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XWear.Application.Features.Account.Commands.Update;
using XWear.Application.Features.Account.Common;
using XWear.Application.Features.Account.Queries.GetAccount;
using XWear.Contracts.Account;

namespace XWear.WebApi.Controllers;

/// <summary>
/// Контроллер для аккаунта
/// </summary>
[Authorize]
public class AccountController : ApiController
{
    /// <summary>
    /// Получить информацию о аккаунте
    /// </summary>
    /// <returns>Информация о аккаунте</returns>
    [HttpGet]
    [ProducesResponseType(typeof(AccountResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAccount()
    {
        var query = new GetAccountQuery();
        var result = await Mediator.Send(query);
        return result.Match(
            result => Ok(Mapper.Map<AccountResponse>(result)),
            errors => Problem(errors));
    }

    /// <summary>
    /// Обновить информацию о аккаунте
    /// </summary>
    /// <param name="request">Запрос на обновления аккаунта</param>
    /// <returns>Ответ об успешном обновлении</returns>
    [HttpPut("update")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public async Task<IActionResult> UpdateAccount(UpdateAccountRequest request)
    {
        var command = Mapper.Map<UpdateAccountCommand>(request);
        var result = await Mediator.Send(command);
        return result.Match(
            result => Ok(result),
            errors => Problem(errors));
    }
}
