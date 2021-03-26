using Selenium_GoogleSearch.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace Selenium_GoogleSearch
{
    public class GooglePage : WaitHelper
    {
        private readonly IWebDriver driver;

        #region Constructors

        public GooglePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region Properties

        [FindsBy(How = How.XPath, Using = "//*[@type='text']")]
        private IWebElement searchInputField;

        [FindsBy(How = How.XPath, Using = "//*[@name='btnK' and @type='submit']")]
        private IWebElement searchButton;

        [FindsBy(How = How.ClassName, Using = "g")]
        private IList<IWebElement> searchResults;

        By googleSearchResults = By.Id("rso");

        #endregion

        #region Methods

        public void SearchForText(string text)
        {
            WaitUntilElementToBeClickable(searchInputField, 10);
            searchInputField.SendKeys(text);
            searchButton.Click();
        }

        public string GetSearchResults()
        {
            WaitUntilElementExists(googleSearchResults, 10);
            return searchResults[3].Text;
        }

        #endregion
    }
}
