using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Application.Authentication;
public interface IAuthenticationService
{
    (byte[], byte[]) GetPasswordHashAndSalt(string password, CancellationToken cancellationToken = default);
    bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
}
