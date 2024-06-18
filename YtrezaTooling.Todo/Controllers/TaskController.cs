using Microsoft.AspNetCore.Mvc;

namespace YtrezaTooling.Todo.Controllers;

[ApiController]
[Route("[controller]")]
public partial class TaskController : ControllerBase
{

    private readonly ILogger<TaskController> _logger;

    public TaskController(ILogger<TaskController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Tasks")]
    public IEnumerable<TodoTask> Get()
    {
        return new TaskListInMemory().GetAll();
    }
}