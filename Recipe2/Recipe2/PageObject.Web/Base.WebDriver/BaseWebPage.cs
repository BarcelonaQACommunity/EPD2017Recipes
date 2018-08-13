using ClassLibrary1.Base.Contracts;
using OpenQA.Selenium;
using PageObject.Interfaces;

namespace PageObject.Web.Base.WebDriver
{
    public class BaseWebPage : IBaseWebPage
    {
        protected IWebDriver webDriver;

        public BaseWebPage(ISetUpDriver setUpDriver)
        {
            this.webDriver = setUpDriver.InitDriver();
        }
    }
}
