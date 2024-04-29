using System.Linq.Expressions;

namespace Tumin.Cargo.DataAccessLayer.Abstract;

public interface IGenericDal<T> where T : class
{
    Task<List<T>>GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T?> DeleteAsync(int id);
    
    /*Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<List<T>> GetAllByFilterAsync(Expression<Func<T, bool>> filter);
    Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);
    Task<int> CountAsync(Expression<Func<T, bool>> filter);
    Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
    Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> filter);
    Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> filter);
    Task<T> AddRangeAsync(List<T> entities);
    Task<T> UpdateRangeAsync(List<T> entities);
    Task DeleteRangeAsync(List<T> entities);
    Task<int> SaveChangesAsync();
    Task<T> AddOrUpdateAsync(T entity);
    Task<T> AddOrUpdateRangeAsync(List<T> entities);
    Task<List<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllByFilterAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties);
    Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties);
    Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties);
    Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, int? skip, int? take, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, int? skip, int? take, bool asNoTracking, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, int? skip, int? take, bool asNoTracking, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, int? skip, int? take, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, int? skip, int? take, bool asNoTracking, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, int? skip, int? take, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, bool asNoTracking, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(int? skip, int? take, bool asNoTracking, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(int? skip, int? take, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(bool asNoTracking, params Expression<Func<T, object>>[] includeProperties);
    Task<List<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);*/
}