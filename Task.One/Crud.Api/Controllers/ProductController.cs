using Autofac;
using Crud.Application.Commands;
using Crud.Application.DTOs;
using Crud.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        private readonly ILifetimeScope _scope;
        private readonly IMediator _mediator;

        public ProductController(ILogger<ProductController> logger,
            ILifetimeScope scope,IMediator mediator)
        {
            _logger = logger;
            _scope = scope;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var products = await _mediator.Send(new GetProductsQuery());
                return Ok(products);
            }catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody]ProductDto product)
        {
            try
            {
                await _mediator.Send(new AddProductCommand(product));
                return Ok();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest();
            }
        }
    }
}
