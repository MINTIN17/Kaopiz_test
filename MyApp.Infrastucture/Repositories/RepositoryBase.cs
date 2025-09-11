using Microsoft.EntityFrameworkCore;
using MyApp.Domain.Data;
using MyApp.Domain.Entities.Base;
using MyApp.Infrastucture.Data;

namespace MyApp.Infrastucture.Repositories;

public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : EntityBase
{
    private DbSet<TEntity>? _dbSet;
    protected DbSet<TEntity> DbSet => _dbSet ??= _dbContext.Set<TEntity>();

    private readonly MyAppDbContext _dbContext;

    public RepositoryBase(MyAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<TEntity> GetAll()
    {
        return _dbContext.Set<TEntity>();
    }

    public IQueryable<TEntity> QueryGetById(int id)
    {
        return _dbContext.Set<TEntity>().Where(e => e.Id == id);
    }

    public async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _dbContext.Set<TEntity>().FindAsync(id);
    }

    public void Add(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
    }

    public void Update(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
    }

    public void Delete(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
    }

    public async Task AddRangeAsync(IEnumerable<TEntity> entities)
    {
        await _dbContext.Set<TEntity>().AddRangeAsync(entities);
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        _dbContext.Set<TEntity>().RemoveRange(entities);
    }

    public async Task<(IEnumerable<TEntity>, int)> ApplyPaing(IQueryable<TEntity> queryable, int page, int pageSize)
    {
        var totalCount = await queryable.CountAsync();
        return (await queryable.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync(), totalCount);
    }

    public IQueryable<TEntity> IgnoreQueryFilters(IQueryable<TEntity> queryable)
    {
        return queryable.IgnoreQueryFilters();
    }
}
