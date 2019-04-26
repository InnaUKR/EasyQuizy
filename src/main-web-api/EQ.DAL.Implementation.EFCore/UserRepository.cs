using EQ.DAL.Domain;
using EQ.DAL.Infrastructure.Implementation.Repository.EFCore;
using EQ.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EQ.DAL.Implementation.EFCore
{
    public class UserRepository : BaseEFCoreRepositoryAsync<User, Guid>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {

        }

        public async Task<User> GetUserBySecurityIdAsync(Guid securityId)
        {
            return await GetSingleOrDefaultAsync(x => x.SecurityId == securityId);
        }
    }
}