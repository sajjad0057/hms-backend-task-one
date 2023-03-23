using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.Commands.Validators
{
    public class RemoveProductCommandValidator : AbstractValidator<RemoveProductCommand>
    {
        public RemoveProductCommandValidator()
        {
            RuleFor(x => x.product.Id).NotEmpty().NotNull();
            RuleFor(x => x.product.Name).NotNull().NotEmpty();
            RuleFor(x => x.product.Description).NotEmpty().MinimumLength(25);
            RuleFor(x => x.product.Price).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
