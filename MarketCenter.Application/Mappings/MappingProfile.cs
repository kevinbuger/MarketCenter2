using AutoMapper;
using MarketCenter.Application.Features.Orders.Commands.CheckoutOrder;
using MarketCenter.Application.Features.Orders.Commands.UpdateOrder;
using MarketCenter.Application.Features.Orders.Queries.GetOrdersList;
using MarketCenter.Domain.Entities;

namespace MarketCenter.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}
