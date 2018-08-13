using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

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

        [Then(@"The user check that the title '(.*)' and the content '(.*)' and the color '(.*)' from the task are the correct values")]
        public void ThenTheUserCheckThatTheTitleAndTheContentFromTheTaskAreTheCorrectValues(string p0, string p1, string p3)
        {
            IWebElement lbltitle = _webDriver.FindElement(By.Name("title"));
            IWebElement lbldescription = _webDriver.FindElement(By.Name("description"));
            IWebElement boxTodoItem = _webDriver.FindElement(By.Id("item-1"));

            Assert.AreEqual(p0, lbltitle.Text);
            Assert.AreEqual(p1, lbldescription.Text);
            Assert.IsTrue(boxTodoItem.GetAttribute("style").ToLower().Contains(p3.ToLower()));
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var chromeFullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "//binaries";
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            chromeOptions.AddArguments("disable-infobars");

            _webDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(chromeFullPath), new ChromeOptions(), TimeSpan.FromSeconds(30));
            _webDriver.Manage().Window.Maximize();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _webDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(15);

            _webDriver.Navigate().GoToUrl("https://todoauto.azurewebsites.net/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _webDriver?.Dispose();
            _webDriver = null;
        }

    }
}
