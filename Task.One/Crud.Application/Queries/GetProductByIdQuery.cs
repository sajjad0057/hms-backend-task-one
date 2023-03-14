using Crud.Application.DTOs;
using MediatR;

namespace Crud.Application.Queries
{
    public sealed record GetProductByIdQuery(Guid id) : IRequest<ProductDto>;
}
