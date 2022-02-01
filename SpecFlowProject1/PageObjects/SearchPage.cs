using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.PageObjects
{
    class SearchPage
    {
        public IWebDriver driver;

        private By searchField = By.Id("js--search");
        private By searchButton = By.ClassName("btn");

        public SearchPage()
        {
            driver = MainHooks.driver;
        }

        public void ClickSearchField()
        {
            driver.FindElement(searchField).Click();
        }

        public void TypeToSearchField()
        {
            driver.FindElement(searchField).SendKeys("Harpercollins");
        }

        public void ClickSearchButton()
        {
            driver.FindElement(searchButton).Click();
        }

        public bool IsSearchResultDisplayed()
        {
            return driver.Url == @"https://www.rokomari.com/search?term=Harpercollins";
        }
    }
}
