
using Crud.Application.DTOs;
using Crud.Application.Queries;
using Crud.Application.Services;
using MediatR;

namespace Crud.Application.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        private readonly IProductService _productService;

        public GetProductByIdHandler(IProductService productService) => _productService = productService;
        
        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _productService.GetProductByIdAsync(request.id);
        }
    }
}
