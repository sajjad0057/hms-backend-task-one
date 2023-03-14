using AutoMapper;
using Crud.Application.DTOs;
using Crud.Application.UnitOfWorks;
using Crud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task AddProduct(ProductDto product)
        {
            _applicationUnitOfWork.Products.Add(_mapper.Map<Product>(product))
        }
    }
}
