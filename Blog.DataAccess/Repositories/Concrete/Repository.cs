using Blog_Api.Core.Entities.Base;
using Blog_Api.DataAccess.Contexts;
using Blog_Api.DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Blog_Api.DataAccess.Repositories.Concrete;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
{
    readonly BlogContext _context;

    public Repository(BlogContext context)
    {
        _context = context;
    }

    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public async Task CreateAsync(TEntity entity)
    {
        await Table.AddAsync(entity);
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _context.Remove(entity);
    }

    public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> expression, params string[] includes)
    {
        return Include(Table, includes).Where(expression);
    }

    public async Task<TEntity> FindByIdAsync(int id, params string[] includes)
    {
        if (includes.Length == 0)
        {
            return await Table.FindAsync(id);
        }
        var query = Table.AsQueryable();
        return await Include(query, includes).SingleOrDefaultAsync(t => t.Id == id);
    }

    public IQueryable<TEntity> GetAll(params string[] includes)
    {
        var query = Table.AsQueryable();
        return Include(query, includes);
    }

    public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> expression, params string[] includes)
    {
        return await Include(Table, includes).SingleOrDefaultAsync(expression);
    }

    public async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await Table.AnyAsync(expression);
    }

    public async void ReverceSoftDelete(TEntity entity)
    {
        entity.IsDeleted = false;
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void SoftDelete(TEntity entity)
    {
        entity.IsDeleted = true;
    }
    IQueryable<TEntity> Include(IQueryable<TEntity> query, params string[] includes)
    {
        foreach (var item in includes)
        {
            query = query.Include(item);
        }
        return query;
    }
}