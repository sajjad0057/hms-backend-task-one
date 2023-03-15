using Crud.Application.DTOs;
using MediatR;

namespace Crud.Application.Queries
{
    public sealed record GetProductsQuery : IRequest<IList<ProductDto>>;
}
