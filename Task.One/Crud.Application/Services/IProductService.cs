using Crud.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.Services
{
    public interface IProductService
    {
        Task AddProductAsync(ProductDto product);
        Task<IList<ProductDto>> GetAllProductsAsync();
    }
}
