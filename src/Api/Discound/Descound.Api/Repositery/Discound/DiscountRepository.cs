using Dapper;
using Descound.Api.Entity;
using Npgsql;

namespace Descound.Api.Repositery.Discound
{
    public class DiscountRepository<T> : IDiscountRepository<T> where T :class
    {
        private readonly IConfiguration _configuration;

        public DiscountRepository(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<Coupon> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public async Task<Coupon> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Coupon> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Coupon> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Coupon> GetByNameAsync(string text)
        {
            using var connection = new NpgsqlConnection
                (_configuration.GetConnectionString("ConnectionString"));

            var coupondb = await connection.QueryFirstOrDefaultAsync<Coupon>
                ("select * from coupon where productname=@text", new { ProductName = text });

            //if (coupondb is null)
            //    res.AddParameter("Result", "Not Fount Any Discount");

            //res.AddParameter("Coupon", coupondb);

            return new Coupon { };
        }

        public async Task<Coupon> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }


    }
}