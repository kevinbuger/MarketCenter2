using FluentValidation; 

namespace MarketCenter.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(p => p.Id)
               .NotEmpty().WithMessage("OrderId is required");

            RuleFor(p => p.AccountId)
                .NotEmpty().WithMessage("AccountId is required");


            RuleFor(p => p.TotalPrice)
                .NotEmpty().WithMessage("TotalPrice is required")
               .GreaterThan(0).WithMessage("TotalPrice should be greater than zero");
        }
    }
}
