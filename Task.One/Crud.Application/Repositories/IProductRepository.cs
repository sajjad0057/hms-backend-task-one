using Crud.Domain.Entities;
using Crud.Domain.IRepositories;

namespace Crud.Application.Repositories
{
    public interface IProductRepository : IRepository<Product,int>
    {
    }
}
