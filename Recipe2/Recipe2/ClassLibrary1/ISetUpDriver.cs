using OpenQA.Selenium;

namespace PageObject.Interfaces
{
    public interface ISetUpDriver
    {
        IWebDriver InitDriver();

        void CloseDriver();

        void GoToUrl(string url);
    }
}
