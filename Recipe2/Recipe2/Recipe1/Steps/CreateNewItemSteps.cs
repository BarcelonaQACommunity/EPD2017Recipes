using Autofac;
using Container;
using DataFactory.Entities;
using PageObject.Interfaces;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Recipe1.Steps
{
    [Binding]
    public class CreateNewItemSteps : TechTalk.SpecFlow.Steps
    {
        private readonly IAddTaskPage addTaskPage;

        public CreateNewItemSteps()
        {
            this.addTaskPage = AppContainer.Container.Resolve<IAddTaskPage>();
        }

        [When(@"The user creates a new task with the following properties:")]
        public void TheUserCreatesANewTaskWithTheFollowingProperties(Table table)
        {
            var task = table.CreateInstance<TodoItem>();

            this.addTaskPage.CreateTask(task);
        }

        [When(@"The user creates a group of task with the following properties:")]
        public void TheUserCreatesAGroupOfTasksWithTheFollowingProperties(Table table)
        {
            var taskList = table.CreateSet<TodoItem>();

            foreach (var task in taskList)
            {
                this.Given("The user goes to create new item");
                this.addTaskPage.CreateTask(task);
            }
        }
    }
}
