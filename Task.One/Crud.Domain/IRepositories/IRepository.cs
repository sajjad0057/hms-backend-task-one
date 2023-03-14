using Crud.Domain.Entities;

namespace Crud.Domain.IRepositories
{
    public interface IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        Task AddAsync(TEntity entity);
        Task RemoveAsync(TKey id);
        Task RemoveAsync(TEntity entity);
        Task EditAsync(TEntity entityToUpdate);
        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TKey id);
    }
}
