using EQ.DAL.Domain;
using EQ.DAL.Infrastructure.Implementation.Repository.EFCore;
using EQ.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EQ.DAL.Implementation.EFCore
{
    public class AuthenticatedUserRepository : BaseEFCoreRepositoryAsync<AuthenticatedUser, Guid>, IAuthenticatedUserRepository
    {
        public AuthenticatedUserRepository(DbContext context) : base(context)
        {

        }

        public async Task<AuthenticatedUser> GetUserBySecurityIdAsync(Guid securityId)
        {
            return await GetSingleOrDefaultAsync(x => x.SecurityId == securityId);
        }

        public IQueryable<AuthenticatedUser> GetAllExpired()
        {
            return GetAll().Where(x => x.ExpiredDate <= DateTime.UtcNow);
        }

        public async Task DeleteBySecurityIdAsync(Guid securityId)
        {
            var entity = await GetSingleOrDefaultAsync(x => x.SecurityId == securityId);

            if (entity != null)
            {
                Remove(entity);
            }
        }
    }
}