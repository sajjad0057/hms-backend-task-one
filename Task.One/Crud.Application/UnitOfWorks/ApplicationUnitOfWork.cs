using Crud.Application.DbContexts;
using Microsoft.EntityFrameworkCore;


namespace Crud.Application.UnitOfWorks
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public ApplicationUnitOfWork(IApplicationDbContext dbContext) : base((DbContext)dbContext)
        {
        }
    }
}
