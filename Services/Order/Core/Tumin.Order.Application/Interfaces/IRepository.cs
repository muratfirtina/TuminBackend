using System.Linq.Expressions;

namespace Tumin.Order.Application.Interfaces;

public interface IRepository<T> where T : class
{
    Task<List<T>>GetAllAsync();
    Task<T?> GetByIdAsync(string id);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
    Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter);
}