using Descound.Api.Entity;

namespace Descound.Api.Repositery.Discound
{
    public interface IDiscountRepository<T> where T : class
    {
        Task<Coupon> GetByIdAsync(int id);
        Task<Coupon> GetByNameAsync(string text);
        Task<Coupon> GetAllAsync();
        Task<Coupon> AddAsync(T entity);
        Task<Coupon> UpdateAsync(T entity);
        Task<Coupon> DeleteAsync(T entity);
        Task<bool> DeleteAsync(int Id);
    }
}