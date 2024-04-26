using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Persistence.Context;

namespace Tumin.Order.Persistence.Repositories;

public class Repository<T>:IRepository<T> where T : class
{
    private readonly OrderDbContext _orderDbContext;

    public Repository(OrderDbContext orderDbContext)
    {
        _orderDbContext = orderDbContext;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _orderDbContext.Set<T>().ToListAsync();
    }

    public async Task<T?> GetByIdAsync(string id)
    {
        return await _orderDbContext.Set<T>().FindAsync(Guid.Parse(id));
    }

    public async Task<T> CreateAsync(T entity)
    {
        _orderDbContext.Set<T>().Add(entity);
        await _orderDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _orderDbContext.Entry(entity).State = EntityState.Modified;
        await _orderDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<T> DeleteAsync(T entity)
    {
        _orderDbContext.Set<T>().Remove(entity);
        await _orderDbContext.SaveChangesAsync();
        return null;
    }

    public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
    {
        return await _orderDbContext.Set<T>().SingleOrDefaultAsync(filter);
    }
}