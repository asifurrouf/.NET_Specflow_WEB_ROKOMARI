using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public class MainHooks
    {
       
        public static IWebDriver driver;

        [BeforeScenario]
        public static void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario

            driver = new ChromeDriver(@"D:\Drive");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            driver.Close();
            
        }
    }
}
