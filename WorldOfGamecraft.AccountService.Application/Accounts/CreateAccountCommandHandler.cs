using MediatR;
using WorldOfGamecraft.AccountService.Application.Authentication;
using WorldOfGamecraft.AccountService.Domain.Abstractions;
using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Application.Accounts;
public sealed class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, Guid>
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAccountRepository _accountRepository;

    public CreateAccountCommandHandler(IAuthenticationService authenticationService, IUnitOfWork unitOfWork, IAccountRepository accountRepository)
    {
        _authenticationService = authenticationService;
        _unitOfWork = unitOfWork;
        _accountRepository = accountRepository;
    }

    public async Task<Guid> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
    {
        (byte[] Hash, byte[] Salt) hashAndSalt =  _authenticationService.GetPasswordHashAndSaltAsync(request.Password);

        var account = Account.Create(
            request.Username,
            hashAndSalt.Hash,
            hashAndSalt.Salt,
            null,
            null,
            request.Role);

        _accountRepository.Add(account);
        await _unitOfWork.SaveChangesAsync();

        return account.Id;
    }

}
