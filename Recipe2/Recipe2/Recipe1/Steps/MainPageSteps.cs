using Autofac;
using Container;
using DataFactory.Entities;
using FluentAssertions;
using PageObject.Interfaces;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Recipe1
{
    [Binding]
    public class MainPageSteps : TechTalk.SpecFlow.Steps
    {
        private readonly ISetUpDriver setUpDriver;
        private readonly IMainPage mainPage;

        public MainPageSteps()
        {
            this.setUpDriver = AppContainer.Container.Resolve<ISetUpDriver>();
            this.mainPage = AppContainer.Container.Resolve<IMainPage>();
        }

        [Given(@"The user goes to the main page")]
        public void TheUserGoesToTheMainPage()
        {
            this.setUpDriver.GoToUrl("https://todoauto.azurewebsites.net");
        }

        [Given(@"The user goes to create new item")]
        [When(@"The user goes to create new item")]
        public void TheUserGoesToCreateNewItem()
        {
            this.mainPage.GoToCreateNewTask();
        }

        [Then(@"The testee display the following items:")]
        public void TheTesteeDisplayTheFollowingItems(Table table)
        {
            var expectedItems = table.CreateSet<TodoItem>();
            var realItems = this.mainPage.GetTodoItems();

            realItems.Should().BeEquivalentTo(expectedItems, options => options.WithStrictOrdering());
        }

        [AfterScenario]
        public void AfterScenario()
        {
            this.setUpDriver.CloseDriver();
        }

    }
}
