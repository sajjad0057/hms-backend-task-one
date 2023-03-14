using AutoMapper;
using Crud.Application.DTOs;
using Crud.Application.UnitOfWorks;
using Crud.Domain.Entities;

namespace Crud.Application.Services
{
    public class ProductService : IProductService
    {
        private IApplicationUnitOfWork _applicationUnitOfWork;
        private IMapper _mapper;

        public ProductService(IApplicationUnitOfWork applicationUnitOfWork, IMapper mapper)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
            _mapper = mapper;
        }

        public async Task AddProductAsync(ProductDto product)
        {
            await _applicationUnitOfWork.Products.AddAsync(_mapper.Map<Product>(product));
            await _applicationUnitOfWork.SaveAsync();
        }

        public async Task<IList<ProductDto>> GetAllProductsAsync()
        {
            var products = await _applicationUnitOfWork.Products.GetAllAsync();

            return _mapper.Map<IList<ProductDto>>(products);
        }

        public async Task EditProductAsync(ProductDto product)
        {
            var productEO = await _applicationUnitOfWork.Products.GetByIdAsync(product.Id);
            
            if(productEO is not null)
            {
                _mapper.Map(product, productEO);
                await _applicationUnitOfWork.SaveAsync();
            }
            else
            {
                throw new InvalidOperationException("product doesn't exists !");
            }           
        }
    }
}
