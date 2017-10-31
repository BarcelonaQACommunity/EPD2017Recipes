using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Pageobject.Appium.Factory.Base.Appium;
using Pageobject.Factory.Contracts.Pages.Contracts;
using Factory.SetUp;

namespace Pageobject.Appium.Factory.Pages.Appium
{
    /// <summary>
    /// The android add task page.
    /// </summary>
    /// <seealso cref="Pageobject.Appium.Factory.Base.Appium.AndroidPageObjectBase" />
    /// <seealso cref="Pageobject.Factory.Contracts.Pages.Contracts.IAddTaskPage" />
    public class AndroidAddTaskPage : AndroidPageObjectBase, IAddTaskPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidAddTaskPage"/> class.
        /// </summary>
        public AndroidAddTaskPage(ISetUpWebDriver setUpWebDriver)
            : base(setUpWebDriver)
        {
            throw new NotImplementedException();
        }

        public string TaskContent
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

        public string TaskTitle
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

        public void CreateTask()
        {
            throw new NotImplementedException();
        }

        public void SetTaskColor(string color)
        {
            throw new NotImplementedException();
        }
    }
}
