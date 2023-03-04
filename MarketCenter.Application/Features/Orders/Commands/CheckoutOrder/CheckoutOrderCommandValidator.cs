using FluentValidation;

namespace MarketCenter.Application.Features.Orders.Commands.CheckoutOrder
{
    public class CheckoutOrderCommandValidator : AbstractValidator<CheckoutOrderCommand>
    {
        public CheckoutOrderCommandValidator()
        {
            RuleFor(p => p.AccountId)
                .NotEmpty().WithMessage("AccountId is required");

            RuleFor(p => p.CardNumber).NotEmpty().WithMessage("CardNumber is required");

            RuleFor(p => p.TotalPrice)
                .NotEmpty().WithMessage("TotalPrice is required")
               .GreaterThan(0).WithMessage("TotalPrice should be greater than zero");
        }
    }
}
