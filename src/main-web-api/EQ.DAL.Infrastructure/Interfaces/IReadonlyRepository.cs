using System;
using System.Linq;
using System.Linq.Expressions;

namespace EQ.DAL.Infrastructure.Interfaces
{
    public interface IReadonlyRepository<TEntity, TPrimaryKey>
         where TEntity : IEntity<TPrimaryKey>
    {
        TEntity GetById(TPrimaryKey id);
        bool Any(Expression<Func<TEntity, bool>> criteria);
        IQueryable<TEntity> GetAll(int? take = null);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> criteria, int? take = null);
        int Count();
        int Count(Expression<Func<TEntity, bool>> criteria);
    }
}