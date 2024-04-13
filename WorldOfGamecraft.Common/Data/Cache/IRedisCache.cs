namespace WorldOfGamecraft.Common.Data.Cache;
public interface IRedisCache
{
    Task<string?> GetAsync(Guid key, CancellationToken cancellationToken);
    Task SetAsync(Guid key, string value, CancellationToken cancellationToken);
    Task Invalidate(Guid key, CancellationToken cancellationToken);
}
