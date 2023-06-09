﻿using Autofac;
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
        private readonly IMediator _mediator;

        public ProductController(ILogger<ProductController> logger,
            IMediator mediator)
        {
            _logger = logger;
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


        [HttpGet("{id:Guid}", Name = "GetProductById")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            try
            {
                var products = await _mediator.Send(new GetProductByIdQuery(id));
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
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductDto product)
        {
            try
            {
                await _mediator.Send(new UpdateProductCommand(product));
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteProduct([FromBody] ProductDto product)
        {
            try
            {
                await _mediator.Send(new RemoveProductCommand(product));
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest();
            }
        }


        [HttpDelete("{id:Guid}", Name = "DeleteProductById")]
        public async Task<IActionResult> DeleteProductById(Guid id)
        {
            try
            {
                await _mediator.Send(new RemoveProductByIdCommand(id));
                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest();
            }
        }
    }
}
