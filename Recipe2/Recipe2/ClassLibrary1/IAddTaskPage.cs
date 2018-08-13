using DataFactory.Entities;

namespace PageObject.Interfaces
{
    /// <summary>
    /// The Add Task interface.
    /// </summary>
    public interface IAddTaskPage
    {
        void CreateTask(TodoItem todoItem, bool clickNewItem = true);
    }
}
