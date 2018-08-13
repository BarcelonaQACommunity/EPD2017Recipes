using System.Collections.Generic;
using DataFactory.Entities;

namespace PageObject.Interfaces
{
    public interface IMainPage
    {
        void GoToCreateNewTask();

        IList<TodoItem> GetTodoItems();
    }
}
