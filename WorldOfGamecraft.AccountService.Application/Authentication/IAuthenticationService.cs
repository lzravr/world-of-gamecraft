using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Application.Authentication;
public interface IAuthenticationService
{
    Task<string> CreateAccountAsync(Account account, CancellationToken cancellationToken = default);
    (byte[], byte[]) GetPasswordHashAndSaltAsync(string password, CancellationToken cancellationToken = default);
}
