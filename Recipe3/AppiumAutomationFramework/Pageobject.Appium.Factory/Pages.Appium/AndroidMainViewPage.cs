using System;
using System.Collections.Generic;
using Factory.SetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Pageobject.Appium.Factory.Base.Appium;
using Pageobject.Factory.Contracts.Pages.Contracts;

namespace Pageobject.Appium.Factory.Pages.Appium
{
    /// <summary>
    /// The android main view page.
    /// </summary>
    /// <seealso cref="Pageobject.Appium.Factory.Base.Appium.AndroidPageObjectBase" />
    /// <seealso cref="Pageobject.Factory.Contracts.Pages.Contracts.IMainViewPage" />
    public class AndroidMainViewPage : AndroidPageObjectBase, IMainViewPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidMainViewPage"/> class.
        /// </summary>
        public AndroidMainViewPage(ISetUpWebDriver setUpWebDriver)
            : base(setUpWebDriver)
        {
            throw new NotImplementedException();
        }

        public string Proverb
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int TotalTasks
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AddNewTask()
        {
            throw new NotImplementedException();
        }

        public void CloseDriver()
        {
            throw new NotImplementedException();
        }

        public void GoToTheGroupList()
        {
            throw new NotImplementedException();
        }

        public void SelectTask(int id)
        {
            throw new NotImplementedException();
        }

        public void TakeScreenshot(string scenarioTitle)
        {
            throw new NotImplementedException();
        }
    }
}
