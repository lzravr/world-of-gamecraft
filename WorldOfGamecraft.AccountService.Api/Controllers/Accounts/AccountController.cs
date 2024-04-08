using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldOfGamecraft.AccountService.Application.Accounts;

namespace WorldOfGamecraft.AccountService.Api.Controllers.Accounts;
[Route("api/accounts")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly ISender _sender;

    public AccountController(ISender sender)
    {
        _sender = sender;
    }

    [AllowAnonymous]
    [HttpPost("create")]
    public async Task<IActionResult> Register(
        CreateAccountRequest request,
        CancellationToken cancellationToken)
    {
        var command = new CreateAccountCommand(request.Username, request.Password, request.Role);

        var result = await _sender.Send(command, cancellationToken);

        return Ok(result);
    }
}
