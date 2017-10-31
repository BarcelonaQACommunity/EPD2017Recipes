using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObject.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObject.Web
{
    public class Common : ICommon
    {
        public static IWebDriver webDriver;

        public Common()
        {

        }

        public void CloseDriver()
        {
            webDriver?.Dispose();
            webDriver = null;

        }

        public void InitDriver()
        {
            var chromeFullPath = Directory.GetCurrentDirectory();
            webDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(chromeFullPath), new ChromeOptions(), TimeSpan.FromSeconds(30));
            webDriver.Navigate().GoToUrl("http://qaperformance.azurewebsites.net");
        }
    }
}
