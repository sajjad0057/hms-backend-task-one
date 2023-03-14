using Crud.Domain.Entities;
using System.Linq.Expressions;

namespace Crud.Domain.IRepositories
{
    public interface IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        Task AddAsync(TEntity entity);
        Task RemoveAsync(TKey id);
        Task EditAsync(TEntity entityToUpdate);
        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TKey id);

    }
}
