namespace EQ.DAL.Infrastructure.Interfaces
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; }
    }
}