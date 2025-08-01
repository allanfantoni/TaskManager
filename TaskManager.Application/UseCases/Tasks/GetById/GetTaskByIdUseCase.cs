using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "TASK0000001",
            Description = "This is a sample task description.",
            Priority = Communication.Enums.Priority.Low,
            DueDate = new DateTime(year: 2025, month: 08, day: 07),
            Status = Communication.Enums.Status.NotStarted,
        };
    }
}