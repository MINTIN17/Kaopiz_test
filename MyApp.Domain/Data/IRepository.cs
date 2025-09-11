namespace MyApp.Domain.Data;

public interface IRepository<TEntity>
{
    IQueryable<TEntity> GetAll();
    public IQueryable<TEntity> QueryGetById(int id);
    public IQueryable<TEntity> IgnoreQueryFilters(IQueryable<TEntity> queryable);
    Task<TEntity?> GetByIdAsync(int id);

    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    Task AddRangeAsync(IEnumerable<TEntity> entities);
    void RemoveRange(IEnumerable<TEntity> entities);
    public Task<(IEnumerable<TEntity>, int)> ApplyPaing(IQueryable<TEntity> queryable, int page, int pageSize);
}
