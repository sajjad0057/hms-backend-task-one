using Crud.Application.DbContexts;
using Crud.Domain.Entities;
using Crud.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Crud.Application.Repositories
{
    public class ProductRepository : Repository<Product, int>, IProductRepository
    {
        public ProductRepository(IApplicationDbContext context) : base((DbContext)context)
        {
        }
    }
}
