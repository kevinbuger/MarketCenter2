using MediatR; 

namespace MarketCenter.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommand : IRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public decimal TotalPrice { get; set; }
        public string? CardName { get; set; }
        public string? CardNumber { get; set; }
        public string? Expiration { get; set; }
        public string? CVV { get; set; }
        public string? PaymentMethod { get; set; }
    }
}
