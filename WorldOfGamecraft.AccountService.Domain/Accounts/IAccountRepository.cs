namespace WorldOfGamecraft.AccountService.Domain.Accounts;
public interface IAccountRepository
{
    Task<Account?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    void Add(Account account);
}
