using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EQ.DAL.Infrastructure.Interfaces
{
    public interface IReadonlyRepositoryAsync<TEntity, TPrimaryKey> :
        IReadonlyRepository<TEntity, TPrimaryKey> where TEntity : IEntity<TPrimaryKey>
    {
        Task<TEntity> GetByIdAsync(TPrimaryKey id);
        Task<TEntity> GetSingleOrDefaultAsync(Expression<Func<TEntity, bool>> criteria);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> criteria);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> criteria);
    }
}