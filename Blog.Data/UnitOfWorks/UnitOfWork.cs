using Blog.Core.Entities;
using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;

namespace Blog.Data.UnitOfWorks;

public class UnitOfWork(AppDbContext _context):IUnitOfWork
{
    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }
    IRepository<T> IUnitOfWork.GetRepository<T>()  => new Repository<T>(_context);

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public int Save()
    {
        return _context.SaveChanges();
    }
}