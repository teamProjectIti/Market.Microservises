using Microsoft.EntityFrameworkCore;
using Ordering.Application.Contracts.Persistence.Generic;
using Ordering.Doman.Common.EntityBase;
using Ordering.infrastructure.Persistence;
using SendGrid.Helpers.Mail;
using System.Linq.Expressions;

namespace Ordering.infrastructure.Repositeries
{
    public class RepositoryBase<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _dbContext;

        public RepositoryBase(MyContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            if (disableTracking) query = query.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(includeString)) query = query.Include(includeString);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<Expression<Func<T, object>>> includes = null, bool disableTracking = true)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            if (disableTracking) query = query.AsNoTracking();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        //public async Task DeleteAsync(T entity)
        //{
        //    _dbContext.Set<T>().Remove(entity);
        //    await _dbContext.SaveChangesAsync();
        //}

        public virtual T GetEntity(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes)
        {
            var entity = _dbContext.Set<T>().Where(e => e.IsDeleted != true).AsNoTracking();

            if (filter != null)
            {
                entity = entity.Where(filter);
            }

            if (includes?.Length > 0)
            {
                foreach (var include in includes)
                {
                    entity = entity.Include(include);
                }
            }

            return entity.FirstOrDefault();
        }

        public Task<T> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetEntityAsync(Expression<Func<T, bool>> filter = null, List<Expression<Func<T, object>>> includes = null, bool disableTracking = true)
        {
            T _dbSet;
            if (filter != null)
            {
                _dbSet = await _dbContext.Set<T>().Where(x=>!x.IsDeleted).FirstOrDefaultAsync(filter);
            }
            else
            {
                _dbSet = await _dbContext.Set<T>().Where(x => !x.IsDeleted).FirstOrDefaultAsync();
            }

            return _dbSet;
        }

        public void Remove(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
              _dbContext.SaveChangesAsync();

        }

        public void RemoveRange(IList<T> entities)
        {
            _dbContext.Set<T>().RemoveRange(entities);
              _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteRangeAsync(List<T> entities)
        {
            _dbContext.Set<T>().RemoveRange(entities);
            return await _dbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
