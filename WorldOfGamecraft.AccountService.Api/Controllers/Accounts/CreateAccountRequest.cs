using WorldOfGamecraft.Common;

namespace WorldOfGamecraft.AccountService.Api.Controllers.Accounts;

public sealed record CreateAccountRequest(string Username, string Password, Role Role);