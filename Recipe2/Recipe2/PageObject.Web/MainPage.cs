using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageObject.Interfaces;

namespace PageObject.Web
{
    public class MainPage : IMainPage
    {
        #region .: Web Elements :.

        [FindsBy(How = How.ClassName, Using = "well")]
        private IList<IWebElement> _taskList;

        [FindsBy(How = How.XPath, Using = "//p/a")]
        private IWebElement _addTask;

        #endregion
        
        public MainPage()
        {
            PageFactory.InitElements(Common.webDriver, this);
        }


        public String GetLastTitle()
        {
            String LastId = "item-" + (_taskList.Count-1);
            IWebElement LastElem = Common.webDriver.FindElement(By.Id(LastId));
            return LastElem.FindElement(By.Name("title")).Text;
        }

        public String GetLastDescription()
        {
            String LastId = "item-" + (_taskList.Count - 1);
            IWebElement LastElem = Common.webDriver.FindElement(By.Id(LastId));
            return LastElem.FindElement(By.Name("description")).Text;
        }

        public String GetLastColor()
        {
            String LastId = "item-" + (_taskList.Count - 1);
            IWebElement LastElem = Common.webDriver.FindElement(By.Id(LastId));
            return LastElem.GetCssValue("color");
        }

        public void AddNewTask()
        {
            _addTask.Click();
        }
    }
}
