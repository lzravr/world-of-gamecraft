using MediatR;
using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Application.Accounts;
public sealed record CreateAccountCommand(string Username, string Password, Role Role) : IRequest<Guid>;
