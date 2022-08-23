using Core.Entities;
using System.Linq.Expressions;

namespace EntityFrameworkCore.EntityFrameworkCore.Repositories
{
    public interface IStockTrackingRepository<T> where T : Entity
    {
        T Add(T entity);
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entity);
        List<T> List(Expression<Func<T, bool>> predicate);
        Task<List<T>> ListAsync(Expression<Func<T, bool>> predicate);
        List<T> List();
        Task<List<T>> ListAsync();
        T? Get(Expression<Func<T, bool>> predicate);
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);
        T Update(T entity);
        Task<T> UpdateAsync(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entity);
        void Delete(T entity);
        Task DeleteAsync(T entity);
        void Delete(object id);
        Task DeleteAsync(object id);
        Task DeleteRangeAsync(IEnumerable<T> entities);
        IQueryable<T> Query(Expression<Func<T, bool>> predicate);
        IQueryable<T> Query();
    }
}
