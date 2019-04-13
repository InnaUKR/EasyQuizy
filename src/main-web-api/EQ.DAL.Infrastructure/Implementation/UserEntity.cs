using EQ.DAL.Infrastructure.Interfaces;

namespace EQ.DAL.Infrastructure.Implementation
{
    public abstract class UserEntity<TPrimaryKey, TSecurityKey> : BaseEntity<TPrimaryKey>, IUserEntity<TPrimaryKey, TSecurityKey>
    {
        public virtual TSecurityKey SecurityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}