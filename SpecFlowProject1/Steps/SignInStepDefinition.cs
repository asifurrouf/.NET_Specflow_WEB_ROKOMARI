using FluentAssertions;
using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class SignInStepDefinition
    {
        public IWebDriver driver = MainHooks.driver;
        SignIn _signIn = new SignIn();

      
        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            driver.Navigate().GoToUrl("https://www.rokomari.com/book");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5);
        }

        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            _signIn.IsSignInPageDisplayed();
            Thread.Sleep(5);
        }

        [When(@"User enter UserName and Password")]
        public void WhenUserEnterUserNameAndPassword()
        {
            _signIn.TypeUsername_Password();
           
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            _signIn.ClickSignIn();
            
        }

        [Then(@"Successful LogIN home page should display")]
        public void ThenSuccessfulLogINHomePageShouldDisplay()
        {
            _signIn.IsSignInHomePageDisplayed().Should().BeTrue();
        }

    }
}






