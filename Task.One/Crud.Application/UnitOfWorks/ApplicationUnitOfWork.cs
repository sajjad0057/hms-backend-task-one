using Crud.Application.DbContexts;
using Crud.Application.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Crud.Application.UnitOfWorks
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IProductRepository Products { get; private set; }
        public ApplicationUnitOfWork(IApplicationDbContext dbContext,
            IProductRepository productRepository) : base((DbContext)dbContext)
        {
            Products = productRepository;
        }
    }
}
