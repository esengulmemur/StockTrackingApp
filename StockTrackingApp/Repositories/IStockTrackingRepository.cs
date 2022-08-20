using StockTrackingApp.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingApp.Repositories
{
    public interface IStockTrackingRepository<T> where T : Entity
    {
        T Add(T entity);
        List<T> List(Expression<Func<T, bool>> predicate);
        List<T> List();
        T? Get(Expression<Func<T, bool>> predicate);
        T Update(T entity);
        void Delete(T entity);
        void Delete(object id);
        IQueryable<T> Query(Expression<Func<T, bool>> predicate);
    }
}
