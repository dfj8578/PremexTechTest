using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PremexTechnicalTest
{
    [Binding]

    public class Hooks
    {
        IWebDriver driver;



        [BeforeScenario]
        public void BeforeScenario()
        {
            PropertiesCollections.driver = new ChromeDriver();
            PropertiesCollections.driver.Navigate().GoToUrl("https://www.google.com");
            PropertiesCollections.driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // driver.Close();
        }
    }
}


