using Microsoft.EntityFrameworkCore;
using WorldOfGamecraft.AccountService.Domain.Abstractions;

namespace WorldOfGamecraft.AccountService.Infrastructure.Repositories;
public abstract class Repository<TEntity, TId>
    where TEntity : Entity
{
    protected readonly ApplicationDbContext DbContext;

    protected Repository(ApplicationDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken)
    {
        return await DbContext.Set<TEntity>().FirstOrDefaultAsync(entity => entity.Id.Equals(id), cancellationToken);
    }

    public void Add(TEntity entity)
    {
        DbContext.Add(entity);
    }

    public void Update(TEntity entity)
    {
        DbContext.Update(entity);
    }
}
