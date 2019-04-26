using EQ.DAL.Domain;
using EQ.DAL.Infrastructure.Interfaces;
using System;
using System.Threading.Tasks;

namespace EQ.DAL.Interfaces
{
    public interface IUserRepository : IRepositoryAsync<User, Guid>
    {
        Task<User> GetUserBySecurityIdAsync(string securityId);
    }
}