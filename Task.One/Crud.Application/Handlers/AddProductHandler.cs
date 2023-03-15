using Crud.Application.Commands;
using Crud.Application.DTOs;
using Crud.Application.Services;
using MediatR;

namespace Crud.Application.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand>
    {
        private readonly IProductService _productService;

        public AddProductHandler(IProductService productService) => _productService = productService;

        public async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _productService.AddProductAsync(request.product);
        }
    }
}
