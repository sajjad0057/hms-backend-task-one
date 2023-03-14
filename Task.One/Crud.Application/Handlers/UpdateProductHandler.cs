using Crud.Application.Commands;
using Crud.Application.Services;
using MediatR;

namespace Crud.Application.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IProductService _productService;

        public UpdateProductHandler(IProductService productService) => _productService = productService;

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            await _productService.EditProductAsync(request.product);
        }
    }
}
