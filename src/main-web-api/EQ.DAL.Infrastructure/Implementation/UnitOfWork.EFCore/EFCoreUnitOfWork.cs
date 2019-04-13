using EQ.DAL.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace EQ.DAL.Infrastructure.Implementation.UnitOfWork.EFCore
{
    public class EFCoreUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public EFCoreUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    try
                    {
                        this.Commit();
                    }
                    catch (Exception)
                    {
                        this.Rollback();
                        throw new Exception("Database operation was failed!");
                    }
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}