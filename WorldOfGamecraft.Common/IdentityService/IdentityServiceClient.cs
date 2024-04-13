
using Microsoft.Extensions.Configuration;

namespace WorldOfGamecraft.Common.IdentityService;
public sealed class IdentityServiceClient : IIdentityServiceClient
{
    private readonly IConfiguration _configuration;

    public IdentityServiceClient(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<string> GetAccountIdByUsername(string username, CancellationToken cancellationToken)
    {
        var uri = _configuration.GetSection("IdentityService:Uri").Value;
        var token = _configuration.GetSection("IdentityService:Token").Value;
        var endpoint = "/api/accounts/";
        var fullPath = uri + endpoint + username;

        using var httpClient = new HttpClient();

        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

        try
        {
            var response = await httpClient.GetAsync(fullPath);

            return await response.Content.ReadAsStringAsync();

        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
