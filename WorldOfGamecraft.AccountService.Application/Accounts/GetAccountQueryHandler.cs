using MediatR;
using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Application.Accounts;
public sealed class GetAccountQueryHandler : IRequestHandler<GetAccountQuery, string?>
{
    private readonly IAccountRepository _accountRepository;

    public GetAccountQueryHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<string?> Handle(GetAccountQuery request, CancellationToken cancellationToken)
    {
        var account =  await _accountRepository.GetByUsernameAsync(request.Username, cancellationToken);

        if (account is null)
        {
            throw new AccountDoesNotExistException();
        }

        return account.Id.ToString();
    }
}
