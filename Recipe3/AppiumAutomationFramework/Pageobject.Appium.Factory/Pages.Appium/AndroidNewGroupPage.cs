using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Pageobject.Appium.Factory.Base.Appium;
using Pageobject.Factory.Contracts.Pages.Contracts;
using Factory.SetUp;
using System;

namespace Pageobject.Appium.Factory.Pages.Appium
{
    /// <summary>
    /// Android new group page.
    /// </summary>
    /// <seealso cref="Pageobject.Appium.Factory.Base.Appium.AndroidPageObjectBase" />
    /// <seealso cref="Pageobject.Factory.Contracts.Pages.Contracts.INewGroupPage" />
    public class AndroidNewGroupPage : AndroidPageObjectBase, INewGroupPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidNewGroupPage"/> class.
        /// </summary>
        public AndroidNewGroupPage(ISetUpWebDriver setUpWebDriver)
            : base(setUpWebDriver)
        {
            throw new NotImplementedException();
        }

        public void CreatesNewGroup(string groupName)
        {
            throw new NotImplementedException();
        }

        public bool IsGroupCreated(string groupName)
        {
            throw new NotImplementedException();
        }

        public void SelectsGroup(string groupName)
        {
            throw new NotImplementedException();
        }
    }
}
