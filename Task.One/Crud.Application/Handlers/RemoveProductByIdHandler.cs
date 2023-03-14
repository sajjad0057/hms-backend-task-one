using Crud.Application.Commands;
using Crud.Application.Services;
using MediatR;

namespace Crud.Application.Handlers
{
    public class RemoveProductByIdHandler : IRequestHandler<RemoveProductByIdCommand>
    {
        private readonly IProductService _productService;

        public RemoveProductByIdHandler(IProductService productService) => _productService = productService;
        
        public async Task Handle(RemoveProductByIdCommand request, CancellationToken cancellationToken)
        {
            await _productService.DeleteProductById(request.id);
        }
    }
}
