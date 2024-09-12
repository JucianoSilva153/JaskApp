using JaskApp.Domain.Entities.Common;
using JaskApp.Domain.Validation;

namespace JaskApp.Domain.Entities;

public sealed class Task : Entity
{
    private string Title { get; set; }
    private string Description { get; set; }
    private string Status { get; set; }

    private ICollection<Tag> Tags { get; set; }

    public Task(string title, string description, string status = "Pendente")
    {
        DomainException.When(string.IsNullOrEmpty(title)
            , "A tarefa deve possuir um titulo!");

        Title = title;
        Description = description;
        Status = status;
    }

    public Task(int id, string title, string description, string status = "Pendente")
    {
        DomainException.When(id <= 0, 
            "Id inserido invalido");
        DomainException.When(string.IsNullOrEmpty(title)
            , "A tarefa deve possuir um titulo!");

        Title = title;
        Description = description;
        Status = status;
    }
}