using System.Threading.Tasks;

namespace EQ.DAL.Infrastructure.Interfaces
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task CommitAsync();
    }
}