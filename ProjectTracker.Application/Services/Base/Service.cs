using Microsoft.EntityFrameworkCore;
using ProjectTracker.Application.Interfaces.Base;
using ProjectTracker.Domain.Entities;
using ProjectTracker.Infrastructure;

namespace ProjectTracker.Application.Services.Base;

public abstract class Service<TEntity>(ProjectTrackerDbContext dbContext) : IService<TEntity>
where TEntity : DomainObject, new()
{
    public async Task<TEntity> CreateAsync(TEntity entity, CancellationToken cancellationToken )
    {
        dbContext.Set<TEntity>().Add(entity);
        await dbContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken )
    {
        dbContext.Set<TEntity>().Remove(entity);
        await dbContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken )
    {
        return await dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken )
    {
        return await dbContext.Set<TEntity>().ToListAsync(cancellationToken);
    }
}