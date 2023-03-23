using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.Commands.Validators
{
    public class RemoveProductByIdCommandValidator : AbstractValidator<RemoveProductByIdCommand>
    {
        public RemoveProductByIdCommandValidator()
        {
            RuleFor(x => x.id).NotEmpty().NotNull();
        }
    }
}
