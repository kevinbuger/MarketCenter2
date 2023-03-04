using MediatR; 

namespace MarketCenter.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IRequest<List<OrdersVm>>
    {
        public int AccountId { get; set; }

        public GetOrdersListQuery(int accountId)
        {
            AccountId = accountId;
        }
    }
}
