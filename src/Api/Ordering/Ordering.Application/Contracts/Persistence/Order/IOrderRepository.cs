using Ordering.Application.Contracts.Persistence.Generic;
using Ordering.Doman.Common.Entities;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Persistence.Order
{
    public interface IOrderRepository : IAsyncRepository<Orders>
    {
       // Task<IEnumerable<Orders>> GetOrdersByUserName(string userName);
    }
}
