using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowProject1.PageObjects
{
    class SignIn
    {

        public IWebDriver driver;
        private By userName = By.Id("j_username");
        private By passWord = By.Id("j_password");
        private By signInButton = By.XPath(".//*[@id=\"loginForm\"]/button");

        public SignIn()
        {
            driver = MainHooks.driver;
        }

        public void IsSignInPageDisplayed()
        {
            driver.Navigate().GoToUrl("https://www.rokomari.com/login");
        }
        public void TypeUsername_Password() {

            driver.FindElement(userName).SendKeys("01888018837");
            Thread.Sleep(5);
            driver.FindElement(passWord).SendKeys("lolme1011");
            Thread.Sleep(5);
        }

        public void ClickSignIn()
        {
            driver.FindElement(signInButton).SendKeys(Keys.Enter);
            Thread.Sleep(10);
        }

        public bool IsSignInHomePageDisplayed()
        {
            return driver.Url == @"https://www.rokomari.com/book";
        }
    }
}
