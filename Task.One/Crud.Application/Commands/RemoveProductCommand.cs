using Crud.Application.DTOs;
using MediatR;

namespace Crud.Application.Commands
{
    public sealed record RemoveProductCommand(ProductDto product) : IRequest;
}
