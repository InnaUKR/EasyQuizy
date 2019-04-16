using EQ.DAL.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EQ.DAL.Infrastructure.Implementation.Repository.EFCore
{
    public class BaseEFCoreRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>, IDisposable where
        TEntity : BaseEntity<TPrimaryKey>
    {
        private readonly DbContext _context;

        protected DbSet<TEntity> DbSet { get; }

        public BaseEFCoreRepository(DbContext context)
        {
            _context = context;
            DbSet = context.Set<TEntity>();
        }

        #region IRepository members

        #region IReadonlyRepository members

        public TEntity GetById(TPrimaryKey id)
        {
            return DbSet.Find(id);
        }

        public bool Any(Expression<Func<TEntity, bool>> criteria)
        {
            return DbSet.Any(criteria);
        }

        public IQueryable<TEntity> GetAll(int? take = null)
        {
            if (take.HasValue)
            {
                return DbSet.Take(take.Value);
            }

            return DbSet.AsQueryable();
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> criteria, int? take = null)
        {
            if (take.HasValue)
            {
                return DbSet.Where(criteria).Take(take.Value);
            }

            return DbSet.Where(criteria);
        }

        public int Count()
        {
            return DbSet.Count();
        }

        public int Count(Expression<Func<TEntity, bool>> criteria)
        {
            return DbSet.Count(criteria);
        }

        #endregion

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            DbSet.UpdateRange(entities);
        }

        public void RemoveById(TPrimaryKey id)
        {
            var entity = GetById(id);

            if (entity != null)
            {
                Remove(entity);
            }
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Remove(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        #endregion

        #region IDisposable members

        public void Dispose()
        {
            _context.Dispose();
        }

        #endregion        
    }
}