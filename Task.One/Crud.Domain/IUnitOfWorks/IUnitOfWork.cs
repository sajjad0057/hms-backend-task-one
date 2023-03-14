namespace Crud.Domain.IUnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        Task SaveAsync();
    }
}
