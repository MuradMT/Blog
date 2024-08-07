using System.Linq.Expressions;
using Blog.Core.Entities;
using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Repositories.Concretes;

public class Repository<T>(AppDbContext _context):IRepository<T>
    where T:class,IEntityBase,new()
{
    private DbSet<T> Table {get => _context.Set<T>();}

    public async Task<IList<T>> GetAllAsync(Expression<Func<T,bool>> predicate=null,params Expression<Func<T,object>>[] includeProperties)
    {
        IQueryable<T> query = Table;
        if (predicate is not null)
            query = query.Where(predicate);
        if (includeProperties.Any())
        {
            foreach (var item in includeProperties)
            {
                query = query.Include(item);
            }
        }

        return await query.ToListAsync();

    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> predicate , params Expression<Func<T, object>>[] includeProperties)
    {
        IQueryable<T> query = Table;
        query = query.Where(predicate);
        if (includeProperties.Any())
        {
            foreach (var item in includeProperties)
            {
                query = query.Include(item);
            }
        }

        return await query.SingleAsync();
    }

    public async Task<T> GetByGuidAsync(Guid id)
    {
        return await Table.FindAsync(id);
    }

    public async Task<T> UpdateAsync(T entity)
    {
        await Task.Run((() =>
        {
            Table.Update(entity);
        }));
        return entity;
    }

    public async Task DeleteAsync(T entity)
    {
        await Task.Run((() =>
        {
            Table.Remove(entity);
        }));
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
    {
        return await Table.AnyAsync(predicate);
    }

    public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
    {
        return await Table.CountAsync(predicate);
    }

    public async Task AddAsync(T entity)
    {
        await Table.AddAsync(entity);
    }
    
}