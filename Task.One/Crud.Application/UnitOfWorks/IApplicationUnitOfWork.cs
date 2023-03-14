using Crud.Application.Repositories;
using Crud.Domain.IUnitOfWorks;

namespace Crud.Application.UnitOfWorks
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        IProductRepository Products { get; }
    }
}
