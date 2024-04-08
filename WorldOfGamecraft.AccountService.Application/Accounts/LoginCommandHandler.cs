using MediatR;
using WorldOfGamecraft.AccountService.Application.Authentication;
using WorldOfGamecraft.AccountService.Domain.Abstractions;
using WorldOfGamecraft.AccountService.Domain.Accounts;

namespace WorldOfGamecraft.AccountService.Application.Accounts;
internal class LoginCommandHandler : IRequestHandler<LoginCommand, Tokens>
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAccountRepository _accountRepository;
    private readonly IJwtService _jwtService;

    public LoginCommandHandler(IAuthenticationService authenticationService, IUnitOfWork unitOfWork, IAccountRepository accountRepository, IJwtService jwtService)
    {
        _authenticationService = authenticationService;
        _unitOfWork = unitOfWork;
        _accountRepository = accountRepository;
        _jwtService = jwtService;
    }

    public async Task<Tokens> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetByUsernameAsync(request.Username, cancellationToken);

        if (account is null || !_authenticationService.VerifyPasswordHash(request.Password, account.PasswordHash, account.PasswordSalt))
        {
            throw new WrongCredentialsException();
        }

        var jwt = _jwtService.GenerateJwtToken(account);
        var refresh = _jwtService.GenerateRefreshToken();

        account.RefreshToken = refresh;
        account.ValidUntil = DateTime.UtcNow.AddDays(10);

        _accountRepository.Update(account);
        await _unitOfWork.SaveChangesAsync();

        return new Tokens(jwt, refresh);
    }
}
