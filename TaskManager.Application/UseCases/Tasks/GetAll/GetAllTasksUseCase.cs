using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            //Tasks = new List<ResponseShortTaskJson>
            //{
            //    new ResponseShortTaskJson
            //    {
            //        Id = 1,
            //        Name = "TASK0000001",
            //        Description = "This is a sample task description."
            //    },
            //    new ResponseShortTaskJson
            //    {
            //        Id = 2,
            //        Name = "TASK0000002",
            //        Description = "This is another sample task description."
            //    },
            //    new ResponseShortTaskJson
            //    {
            //        Id = 3,
            //        Name = "TASK0000003",
            //        Description = "This is yet another sample task description." 
            //    }
            //}
        };
    }
}