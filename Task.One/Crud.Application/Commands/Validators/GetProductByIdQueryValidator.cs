
using Crud.Application.Queries;
using FluentValidation;

namespace Crud.Application.Commands.Validators
{
    public class GetProductByIdQueryValidator : AbstractValidator<GetProductByIdQuery>
    {
        public GetProductByIdQueryValidator() 
        {
            RuleFor(x => x.id).NotEmpty().NotNull();
        }
    }
}
