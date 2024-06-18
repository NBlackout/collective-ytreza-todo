using YtrezaTooling.Todo.Controllers;

namespace YtrezaTooling.Todo;

public class TaskListInMemory
{
    public List<TodoTask> GetAll()
    {
        return new List<TodoTask>(){
            new TodoTask("Acheter du lait"),
            new TodoTask("Acheter de l'eau")
        };
    }
}