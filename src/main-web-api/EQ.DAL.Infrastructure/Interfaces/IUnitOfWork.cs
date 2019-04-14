using System;

namespace EQ.DAL.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void Rollback();
    }
}