﻿using Ordering.Application.Contracts.Persistence.Order;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQueryHandler
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrdersListQueryHandler(IOrderRepository orderRepository, IMapper mapper )
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public async Task<List<OrdersVm>> Handle(GetOrdersListQuery request,CancellationToken cancellationToken)
        {
            var orderList = _orderRepository.GetEntityAsync(x =>x == request.UserName);
                            
                return _mapper.Map<List<OrdersVm>>(orderList);

        }

    }
}
