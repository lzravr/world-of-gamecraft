using Microsoft.EntityFrameworkCore;
using WorldOfGamecraft.Common.Abstractions;

namespace WorldOfGamecraft.CharacterService.Infrastructure.Repositories;
public abstract class Repository<TEntity, TId>
    where TEntity : Entity
{
    protected readonly CharactersDbContext DbContext;

    protected Repository(CharactersDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await DbContext.Set<TEntity>().ToListAsync(cancellationToken);
    }

    public virtual async Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken)
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

    public void Delete(TEntity entity)
    {
        DbContext.Remove(entity);
    }
}
