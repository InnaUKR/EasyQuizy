using System.Collections.Generic;

namespace EQ.DAL.Infrastructure.Interfaces
{
    public interface IRepository<TEntity, TPrimaryKey> :
        IReadonlyRepository<TEntity, TPrimaryKey>
        where TEntity : IEntity<TPrimaryKey>
    {
        void Add(TEntity entity);
        void Add(IEnumerable<TEntity> entitites);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entitites);
        void RemoveById(TPrimaryKey id);
        void Remove(TEntity entity);
        void Remove(IEnumerable<TEntity> entitites);
        void SaveChanges();
    }
}