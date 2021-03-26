using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_GoogleSearch.Helpers
{
    public class WaitHelper
    {
        private readonly IWebDriver driver;

        #region Constructors

        public WaitHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        #endregion

        #region Methods

        public void WaitUntilElementToBeClickable(IWebElement element, int timeout)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public void WaitUntilElementExists(By element, int timeout)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));
        }

        #endregion
    }
}
