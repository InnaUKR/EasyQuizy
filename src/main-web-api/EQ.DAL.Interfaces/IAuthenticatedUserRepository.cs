using EQ.DAL.Domain;
using EQ.DAL.Infrastructure.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EQ.DAL.Interfaces
{
    public interface IAuthenticatedUserRepository : IRepositoryAsync<AuthenticatedUser, Guid>
    {
        Task<AuthenticatedUser> GetUserBySecurityIdAsync(Guid securityId);

        IQueryable<AuthenticatedUser> GetAllExpired();

        Task DeleteBySecurityIdAsync(Guid securityId);
    }
}