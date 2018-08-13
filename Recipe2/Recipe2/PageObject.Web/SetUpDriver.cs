using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject.Interfaces;

namespace PageObject.Web
{
    public class SetUpDriver : ISetUpDriver
    {
        private const string DriverPath = @"\binaries";

        public static IWebDriver webDriver;

        public void CloseDriver()
        {
            webDriver?.Quit();
            webDriver?.Dispose();
            webDriver = null;
        }

        public IWebDriver InitDriver()
        {
            if (webDriver == null)
            {
                var chromeFullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + DriverPath;
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--start-maximized");
                chromeOptions.AddArguments("disable-infobars");

                webDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(chromeFullPath), chromeOptions, TimeSpan.FromSeconds(30));
                webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
                webDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(15);
            }

            return webDriver;
        }

        public void GoToUrl(string url)
        {
            if (webDriver == null)
            {
                this.InitDriver();
            }

            webDriver.Navigate().GoToUrl(url);
        }
    }
}
