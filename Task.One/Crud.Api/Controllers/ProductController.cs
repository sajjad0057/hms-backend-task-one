using Autofac;
using Crud.Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        private readonly ILifetimeScope _scope;

        public ProductController(ILogger<ProductController> logger,ILifetimeScope scope)
        {
            _logger = logger;
            _scope = scope;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody]ProductDto product)
        {


            return Ok(product);
        }
    }
}
