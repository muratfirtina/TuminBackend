using System.Linq.Expressions;

namespace Tumin.Cargo.BusinessLayer.Abstract;

public interface IGenericService <T> where T : class
{
    Task<List<T>> TGetAllAsync();
    Task<T> TGetByIdAsync(int id);
    Task<T> TCreateAsync(T entity);
    Task<T> TUpdateAsync(T entity);
    Task<T> TDeleteAsync(int id);
    
    
}