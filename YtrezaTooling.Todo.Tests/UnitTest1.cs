using YtrezaTooling.Todo;
using YtrezaTooling.Todo.Controllers;

namespace YtrezaTooling.Todo.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        TaskListInMemory sut = new TaskListInMemory();
        List<TodoTask> expectedTask = new List<TodoTask>()
        {
            new TodoTask("Acheter du lait"),
            new TodoTask("Acheter de l'eau")
        };
        List<TodoTask> actual = sut.GetAll();
        
        Assert.Equal(expectedTask, actual);
    }
}
