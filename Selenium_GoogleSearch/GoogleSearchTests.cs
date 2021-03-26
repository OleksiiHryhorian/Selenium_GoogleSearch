using NUnit.Framework;
using OpenQA.Selenium;

namespace Selenium_GoogleSearch
{
    public class GoogleSearchTests
    {
        private readonly IWebDriver Driver;
        private readonly GooglePage googlePage;

        private const string URL = "https://google.com";
        private readonly string searchQuery = "Selenium IDE export to C#";
        private readonly string expectedTextInSearchResult = "Selenium IDE";

        public GoogleSearchTests()
        {
            Driver = WebDriver.GetWebDriver();
            googlePage = new GooglePage(Driver);
        }

        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl(URL);
        }

        [Test]
        public void SearchForExpectedText()
        {
            googlePage.SearchForText(searchQuery);
            string actualResult = googlePage.GetSearchResults();
            Assert.That(actualResult, Does.Contain(expectedTextInSearchResult),
                        $@"4th Google Search result doesn't include expected string.
                        Actual search result: {actualResult};
                        Expected text: {expectedTextInSearchResult}");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}