using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Application.Contracts.Infrastructure;
using Ordering.Application.Contracts.Persistence.Order;
using Ordering.Application.Exceptions;
using Ordering.Application.Features.Orders.Commands.CheckoutOrder;



namespace Ordering.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateCheckoutOrderCommand, long>
    {

        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ILogger<CheckoutOrderCommandHandler> _logger;

        public UpdateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, IEmailService emailService, ILogger<CheckoutOrderCommandHandler> logger)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<long> Handle(UpdateCheckoutOrderCommand request, CancellationToken cancellationToken)
        {
                var orderToUpdate = await _orderRepository.GetEntityAsync(x=>x.Id==request.Id);

                if (orderToUpdate == null)
                {
                    throw new NotFoundException(nameof(Doman.Common.Entities.Orders), request.Id);
                }
                _mapper.Map(request, orderToUpdate, typeof(UpdateCheckoutOrderCommand), typeof(Doman.Common.Entities.Orders));
                await _orderRepository.UpdateAsync(orderToUpdate);




            _logger.LogInformation($"Order {orderToUpdate.Id} is successfully updated.");

            //return Unit.Value;
            return orderToUpdate.Id;
        }
    }
}
