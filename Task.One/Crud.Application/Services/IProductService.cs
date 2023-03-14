using Crud.Application.DTOs;

namespace Crud.Application.Services
{
    public interface IProductService
    {
        Task AddProductAsync(ProductDto product);
        Task<IList<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(Guid id);
        Task EditProductAsync(ProductDto product);
        Task DeleteProductAsync(ProductDto product);
        Task DeleteProductById(Guid id);
    }
}
