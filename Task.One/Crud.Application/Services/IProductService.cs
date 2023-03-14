using Crud.Application.DTOs;

namespace Crud.Application.Services
{
    public interface IProductService
    {
        Task AddProductAsync(ProductDto product);
        Task<IList<ProductDto>> GetAllProductsAsync();
        Task EditProductAsync(ProductDto product);
        Task DeleteProductAsync(ProductDto product);
    }
}
