using Ordering.Doman.Common.EntityBase;
using System.Linq.Expressions;

namespace Ordering.Application.Contracts.Persistence.Generic
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeString = null,
                                        bool disableTracking = true);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                       Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                       List<Expression<Func<T, object>>> includes = null,
                                       bool disableTracking = true);

        Task<T> GetEntityAsync(Expression<Func<T, bool>> filter = null,
                                       List<Expression<Func<T, object>>> includes = null,
                                       bool disableTracking = true);
        T GetEntity(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes);

        Task<T> GetByIdAsync(long id);
        Task<T> AddAsync(T entity);

        void Remove(T entity);
        void RemoveRange(IList<T> entity);
        Task UpdateAsync(T entity);
       // Task DeleteAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<int> DeleteRangeAsync(List<T> entities);
    }
}
