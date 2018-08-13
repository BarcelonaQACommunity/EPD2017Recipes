using DataFactory.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageObject.Interfaces;
using PageObject.Web.Base.WebDriver;

namespace PageObject.Web
{
    public class AddTaskPage : BaseWebPage, IAddTaskPage
    {
        #region .: Web Elements :.

        [FindsBy(How = How.Id, Using = "textBox-itemTitle")]
        private IWebElement taskTitleTextBox;

        [FindsBy(How = How.Id, Using = "textBox-itemDescription")]
        private IWebElement taskDescriptionTextBox;

        [FindsBy(How = How.Id, Using = "button-addItem")]
        private IWebElement taskNewItemButton;

        [FindsBy(How = How.Id, Using = "dropDown-itemColor")]
        private IWebElement colorDropDownMenu;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTaskPage"/> class.
        /// </summary>
        /// <param name="setUpDriver">The set up driver.</param>
        public AddTaskPage(ISetUpDriver setUpDriver) 
            : base(setUpDriver)
        {
            PageFactory.InitElements(this.webDriver, this);
        }

        public void CreateTask(TodoItem todoItem, bool clickNewItem = true)
        {
            // Title
            this.taskTitleTextBox.SendKeys(todoItem.Title);

            // Description
            this.taskDescriptionTextBox.SendKeys(todoItem.Content);

            // Color
            this.SetTaskColor(todoItem.Color);

            if (clickNewItem)
            {
                this.taskNewItemButton.Click();
            }
        }

        private void SetTaskColor(string color)
        {
            var isClicked = false;

            foreach (var item in this.colorDropDownMenu.FindElements(By.TagName("option")))
            {
                if (color == item.Text)
                {
                    item.Click();
                    isClicked = true;
                }
            }

            if (!isClicked)
            {
                throw new NotFoundException($"Color {color} not found.");
            }
        }
    }
}
