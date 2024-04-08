using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Application.Authentication;
public interface IJwtService
{
    string GenerateJwtToken(Account account);
    string GenerateRefreshToken();
}
