using Crud.Application.DTOs;
using MediatR;


namespace Crud.Application.Commands
{
    public sealed record AddProductCommand(ProductDto product) : IRequest;
}
