namespace JaskApp.Domain.Entities.Utils;

public enum TaskStatus
{
    Pending,
    Complete
}

public static class TaskStatusExtension
{
    public static string ToFriendlyString(this TaskStatus status)
    {
        return status switch
        {
            TaskStatus.Complete => "Completa",
            TaskStatus.Pending => "Pendente",
            _ => ""
        };
    }
}