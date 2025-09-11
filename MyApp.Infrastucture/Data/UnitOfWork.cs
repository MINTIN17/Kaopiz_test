using MyApp.Domain.Data;

namespace MyApp.Infrastucture.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly MyAppDbContext _context;

    public UnitOfWork(MyAppDbContext context)
    {
        _context = context;
    }

    public async Task CommitTransactionAsync()
    {
        await _context.Database.CommitTransactionAsync();
    }

    public async Task RollbackAsync()
    {
        await _context.Database.RollbackTransactionAsync();
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
    {
        await _context.Database.BeginTransactionAsync(cancellationToken);
    }
}
