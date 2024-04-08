using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Infrastructure.Repositories;
internal sealed class AccountRepository : Repository<Account, Guid>, IAccountRepository
{
    public AccountRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public void Add(Account account)
    {
        throw new NotImplementedException();
    }

    public Task<Account?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
