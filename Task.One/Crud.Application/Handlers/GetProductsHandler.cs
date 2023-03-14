using Crud.Application.DTOs;
using Crud.Application.Queries;
using Crud.Application.Services;
using MediatR;

namespace Crud.Application.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IList<ProductDto>>
    {
        private readonly IProductService _productService;

        public GetProductsHandler(IProductService productService) => _productService = productService;

        public async Task<IList<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _productService.GetAllProductsAsync();
        }
    }
}
