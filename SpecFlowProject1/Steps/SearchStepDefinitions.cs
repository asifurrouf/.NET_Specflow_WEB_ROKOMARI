using FluentAssertions;
using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.PageObjects;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class SearchStepDefinitions
    {

        public IWebDriver driver = MainHooks.driver;
        SearchPage _searchPage = new SearchPage();
       

        [Given(@"I navigate to Rokomari\.com")]
        public void GivenINavigateToRokomari_Com()
        {
            driver.Navigate().GoToUrl("https://www.rokomari.com/book");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5);
        }

        [When(@"I click on the search field")]
        public void WhenIClickOnTheSearchField()
        {
            _searchPage.ClickSearchField();
            Thread.Sleep(5);
        }

        [When(@"I type automation in the search field")]
        public void WhenITypeAutomationInTheSearchField()
        {
            _searchPage.TypeToSearchField();
            Thread.Sleep(5);
        }

        [When(@"I cllick the search button")]
        public void WhenICllickTheSearchButton()
        {
            _searchPage.ClickSearchButton(); 
        }

        [Then(@"the result page is displayed")]
        public void ThenTheResultPageIsDisplayed()
        {
            Thread.Sleep(5);
            _searchPage.IsSearchResultDisplayed().Should().BeTrue();
        }

    }
}
