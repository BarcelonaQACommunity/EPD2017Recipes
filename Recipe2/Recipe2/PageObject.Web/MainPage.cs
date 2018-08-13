using System;
using System.Collections.Generic;
using DataFactory.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageObject.Interfaces;
using PageObject.Web.Base.WebDriver;

namespace PageObject.Web
{
    public class MainPage : BaseWebPage, IMainPage
    {
        #region .: Web Elements :.

        [FindsBy(How = How.Name, Using = "create-new")]
        private IWebElement createNewButton;

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='box-list-item']")]
        private IList<IWebElement> itemBoxList;

        #endregion

        public MainPage(ISetUpDriver setUpDriver)
            : base(setUpDriver)
        {
            PageFactory.InitElements(this.webDriver, this);
        }

        public void GoToCreateNewTask()
        {
            this.createNewButton.Click();
        }

        public IList<TodoItem> GetTodoItems()
        {
            var todoItems = new List<TodoItem>();

            foreach (var itemBox in this.itemBoxList)
            {
                var todoItem = new TodoItem();

                // Title
                todoItem.Title = itemBox.FindElement(By.Name("title")).Text;

                // Description
                todoItem.Content = itemBox.FindElement(By.Name("description")).Text;

                // Color
                todoItem.Color = itemBox.GetAttribute("style").Replace("background: ", string.Empty).Replace(";", string.Empty);

                todoItems.Add(todoItem);
            }

            return todoItems;
        }
    }
}
