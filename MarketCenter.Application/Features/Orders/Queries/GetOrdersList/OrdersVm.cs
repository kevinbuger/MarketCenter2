using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCenter.Application.Features.Orders.Queries.GetOrdersList
{
    public class OrdersVm
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
