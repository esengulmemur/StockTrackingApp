using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EntityFrameworkCore.EntityFrameworkCore.Repositories
{
    public class StockTrackingRepository<T> : IStockTrackingRepository<T> where T : Entity
    {
        private DBContext _dbContext;
        private DbSet<T> _table;

        public StockTrackingRepository()
        {
            _dbContext = new DBContext();
            _table = _dbContext.Set<T>();
        }

        public virtual T Add(T entity)
        {
            try
            {
                var result = _dbContext.Add<T>(entity);
                _dbContext.SaveChanges();

                return result.Entity;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            try
            {
                var result = await _dbContext.AddAsync<T>(entity);
                await _dbContext.SaveChangesAsync();

                return result.Entity;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public virtual List<T> List(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _table.Where(predicate).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
        
        public virtual async Task<List<T>> ListAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return await _table.Where(predicate).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public virtual List<T> List()
        {
            try
            {
                return _table.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
        
        public virtual async Task<List<T>> ListAsync()
        {
            try
            {
                return await _table.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public virtual T? Get(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _table.Where(predicate).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
        
        public virtual Task<T?> GetAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _table.Where(predicate).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public virtual T Update(T entity)
        {
            try
            {
                var result = _dbContext.Update<T>(entity);
                _dbContext.SaveChanges();
                return result.Entity;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
        
        public virtual async Task<T> UpdateAsync(T entity)
        {
            try
            {
                var result = _dbContext.Update<T>(entity);
                await _dbContext.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public virtual void Delete(T entity)
        {
            try
            {
                _dbContext.Remove(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
        
        public virtual async Task DeleteAsync(T entity)
        {
            try
            {
                _dbContext.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public virtual void Delete(object id)
        {
            try
            {
                var entity = _table.Find(id);
                if (entity == null)
                    throw new Exception("Entity can not be found");
                _dbContext.Remove(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
        
        public virtual async Task DeleteAsync(object id)
        {
            try
            {
                var entity = await _table.FindAsync(id);
                if (entity == null)
                    throw new Exception("Entity can not be found");
                _dbContext.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public virtual async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            try
            { 
                _dbContext.RemoveRange(entities);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public virtual IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _table.Where(predicate);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public virtual IQueryable<T> Query()
        {
            try
            {
                return _table;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
    }
}
