using MarketCenter.Application.Contracts.Persistence;
using MediatR;
using AutoMapper;

namespace MarketCenter.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListqueryHandler : IRequestHandler<GetOrdersListQuery, List<OrdersVm>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrdersListqueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<List<OrdersVm>> Handle(GetOrdersListQuery reqeust, CancellationToken cancellationToken)
        {
            var orderList = await _orderRepository.GetOrderByUserName(reqeust.AccountId);
            return _mapper.Map<List<OrdersVm>>(orderList);
        }
    }
}
