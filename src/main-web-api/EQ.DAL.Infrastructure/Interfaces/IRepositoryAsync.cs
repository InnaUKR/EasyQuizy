using System.Collections.Generic;
using System.Threading.Tasks;

namespace EQ.DAL.Infrastructure.Interfaces
{
    public interface IRepositoryAsync<TEntity, TPrimaryKey> :
        IReadonlyRepositoryAsync<TEntity, TPrimaryKey>, IRepository<TEntity, TPrimaryKey>
        where TEntity : IEntity<TPrimaryKey>
    {
        Task AddAsync(TEntity entity);
        Task AddAsync(IEnumerable<TEntity> entitites);
        Task RemoveByIdAsync(TPrimaryKey id);
        Task SaveChangesAsync();
    }
}