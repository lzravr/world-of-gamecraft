
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace WorldOfGamecraft.Common.Data.Cache;
public sealed class RedisCache : IRedisCache, IDisposable
{
    private readonly IConfiguration _configuration;
    private readonly ConnectionMultiplexer _connectionMultiplexer;
    private IDatabase _db;

    public RedisCache(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionMultiplexer = ConnectionMultiplexer.Connect(_configuration.GetConnectionString("RedisConnection") ??
            throw new ArgumentNullException(nameof(configuration)));
        _db = _connectionMultiplexer.GetDatabase();
    }

    public async Task<string?> GetAsync(Guid key, CancellationToken cancellationToken)
    {
        return await _db.StringGetAsync(key.ToString());
    }

    public async Task SetAsync(Guid key, string value, CancellationToken cancellationToken)
    {
        await _db.StringSetAsync(key.ToString(), value);
    }
    public async Task Invalidate(Guid key, CancellationToken cancellationToken)
    {
        await _db.StringGetDeleteAsync(key.ToString());
    }
    public void Dispose()
    {
        _connectionMultiplexer.Dispose();
    }

}
