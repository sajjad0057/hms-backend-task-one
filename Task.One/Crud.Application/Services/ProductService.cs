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
    }
}
