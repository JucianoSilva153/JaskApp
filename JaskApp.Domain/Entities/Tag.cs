using JaskApp.Domain.Validation;

namespace JaskApp.Domain.Entities.Common;

public sealed class Tag : Entity
{
    private string Name { get; set; }

    private ICollection<Task> Tasks { get; set; }

    public Tag(string name)
    {
        DomainException.When(string.IsNullOrEmpty(name),
            "A Tag Precisa de um nome!");

        Name = name;
    }
    
    public Tag(int id ,string name)
    {
        DomainException.When(id <= 0,
            "Id Invalido!");
        DomainException.When(string.IsNullOrEmpty(name),
            "A Tag Precisa de um nome!");

        Id = id;
        Name = name;
    }
}