using EQ.DAL.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EQ.DAL.Infrastructure.Implementation.UnitOfWork.EFCore
{
    public class EFCoreUnitOfWorkAsync : IUnitOfWorkAsync
    {
        private readonly DbContext _context;

        public EFCoreUnitOfWorkAsync(DbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected async virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    try
                    {
                        await this.CommitAsync();
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