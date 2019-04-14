using EQ.DAL.Infrastructure.Interfaces;

namespace EQ.DAL.Infrastructure.Implementation
{
    public abstract class BaseEntity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}