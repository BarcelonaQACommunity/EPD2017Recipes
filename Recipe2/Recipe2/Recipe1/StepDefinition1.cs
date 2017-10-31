using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using Container;
using PageObject.Interfaces;
using Autofac;


namespace Recipe1
{
    [Binding]
    public class StepDefinition1: TechTalk.SpecFlow.Steps
    {
        [Given(@"The user goes to the add task view")]
        public void GivenTheUserGoesToTheAddTaskView()
        {
            IMainPage page = AppContainer.Container.Resolve<IMainPage>();
            page.AddNewTask();
        }

        [When(@"The user sets the task with the title '(.*)', the content '(.*)', and the color '(.*)'")]
        public void WhenTheUserSetsTheTaskWithTheTitleTheContentAndTheColor(string p0, string p1, string p2)
        {
           
            IAddTaskPage page = AppContainer.Container.Resolve<IAddTaskPage>();
            page.TaskTitle = p0;
            page.TaskContent = p1;
            page.SetTaskColor(p2);
            page.CreateTask();

        }

        [Then(@"The user check that the title '(.*)' and the content '(.*)' from the task are the correct values")]
        public void ThenTheUserCheckThatTheTitleAndTheContentFromTheTaskAreTheCorrectValues(string p0, string p1)
        {
            IMainPage page = AppContainer.Container.Resolve<IMainPage>();
            
            Assert.AreEqual(p0, page.GetLastTitle());
            Assert.AreEqual(p1, page.GetLastDescription());

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            AppContainer.Container.Resolve<ICommon>().InitDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            AppContainer.Container.Resolve<ICommon>().CloseDriver();
        }

    }
}
