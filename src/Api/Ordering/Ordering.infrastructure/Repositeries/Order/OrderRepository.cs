using Ordering.Application.Contracts.Persistence.Order;
using Ordering.Doman.Common.Entities;
using Ordering.infrastructure.Persistence;

namespace Ordering.infrastructure.Repositeries.Order
{
    public class OrderRepository : RepositoryBase<Orders>, IOrderRepository
    {
        public OrderRepository(MyContext dbContext) : base(dbContext)
        {
        }

         }
}
