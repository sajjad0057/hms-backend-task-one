namespace Crud.Domain.Infrastructure.IUnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        Task SaveAsync();
    }
}
