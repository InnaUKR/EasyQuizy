namespace EQ.DAL.Infrastructure.Interfaces
{
    public interface IUserEntity<TPrimaryKey, TSecurityKey> : IEntity<TPrimaryKey>
    {
        TSecurityKey SecurityId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
    }
}