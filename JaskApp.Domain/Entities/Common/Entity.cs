namespace JaskApp.Domain.Entities.Common;

public abstract class Entity
{
    public int Id { get; protected set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime ModifiedAt { get; set; }
}