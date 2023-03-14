using Crud.Application.Commands;
using Crud.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.Handlers
{
    public class RemoveProductHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly IProductService _productService;

        public RemoveProductHandler(IProductService productService) => _productService = productService;

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            await _productService.DeleteProductAsync(request.product);
        }
    }
}
