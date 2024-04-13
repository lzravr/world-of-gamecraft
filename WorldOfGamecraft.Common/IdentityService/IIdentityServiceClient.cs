namespace WorldOfGamecraft.Common.IdentityService;
public interface IIdentityServiceClient
{
    public Task<string> GetAccountIdByUsername(string username, CancellationToken cancellationToken);
}
