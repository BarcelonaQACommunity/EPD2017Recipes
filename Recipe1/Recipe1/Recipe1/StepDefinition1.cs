using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Recipe1
{
    [Binding]
    public class StepDefinition1: TechTalk.SpecFlow.Steps
    {
        private static IWebDriver _webDriver;

        [Given(@"The user goes to the add task view")]
        public void GivenTheUserGoesToTheAddTaskView()
        {
            IWebElement buttonCreateNew = _webDriver.FindElement(By.XPath("//p/a"));
            buttonCreateNew.Click();
        }

        [When(@"The user sets the task with the title '(.*)', the content '(.*)', and the color '(.*)'")]
        public void WhenTheUserSetsTheTaskWithTheTitleTheContentAndTheColor(string p0, string p1, string p2)
        {
            IWebElement fieldTitle = _webDriver.FindElement(By.Id("textBox-itemTitle"));
            IWebElement fieldDescription = _webDriver.FindElement(By.Id("textBox-itemDescription"));
            IWebElement cbColor = _webDriver.FindElement(By.Id("dropDown-itemColor"));
            IWebElement btnAdd = _webDriver.FindElement(By.Id("button-addItem"));

            fieldTitle.SendKeys(p0);
            fieldDescription.SendKeys(p1);
            foreach (var item in cbColor.FindElements(By.TagName("option")))
            {
                if (p2 == item.Text)
                {
                    item.Click();
                }
            }

            btnAdd.Click();

        }

        [Then(@"The user check that the title '(.*)' and the content '(.*)' from the task are the correct values")]
        public void ThenTheUserCheckThatTheTitleAndTheContentFromTheTaskAreTheCorrectValues(string p0, string p1)
        {
            IWebElement lbltitle = _webDriver.FindElement(By.Name("title"));
            IWebElement lbldescription = _webDriver.FindElement(By.Name("description"));

            Assert.AreEqual(p0, lbltitle.Text);
            Assert.AreEqual(p1, lbldescription.Text);

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var chromeFullPath = Directory.GetCurrentDirectory();
            _webDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(chromeFullPath), new ChromeOptions(), TimeSpan.FromSeconds(30));
            _webDriver.Navigate().GoToUrl("http://qaperformance.azurewebsites.net");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _webDriver?.Dispose();
            _webDriver = null;
        }

    }
}
