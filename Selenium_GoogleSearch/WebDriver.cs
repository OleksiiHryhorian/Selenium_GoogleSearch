using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_GoogleSearch
{
    public class WebDriver
    {
        public static IWebDriver GetWebDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            return driver;
        }
    }
}
