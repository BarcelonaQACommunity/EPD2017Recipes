using System;
using Factory.SetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Pageobject.Appium.Factory.Base.Appium;
using Pageobject.Factory.Contracts.Pages.Contracts;

namespace Pageobject.Appium.Factory.Pages.Appium
{
    /// <summary>
    /// The android edit task page.
    /// </summary>
    /// <seealso cref="Pageobject.Appium.Factory.Base.Appium.AndroidPageObjectBase" />
    /// <seealso cref="Pageobject.Factory.Contracts.Pages.Contracts.IEditTaskPage" />
    public class AndroidEditTaskPage : AndroidPageObjectBase, IEditTaskPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidEditTaskPage"/> class.
        /// </summary>
        public AndroidEditTaskPage(ISetUpWebDriver setUpWebDriver)
            : base(setUpWebDriver)
        {
            throw new NotImplementedException();
        }

        public string Content
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Title
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void RemoveTask(string task)
        {
            throw new NotImplementedException();
        }
    }
}
