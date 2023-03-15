using FluentValidation;

namespace Crud.Application.Commands.Validators
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.product.Id).NotEmpty().NotNull();
            RuleFor(x => x.product.Name).NotNull().NotEmpty();
            RuleFor(x => x.product.Description).NotEmpty().MinimumLength(25);
            RuleFor(x => x.product.Price).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
