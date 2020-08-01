using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PremexTechnicalTest
{

    [Binding]
    
    public sealed class GoogleSearchTestSteps
    {
        IWebDriver driver;

        [Given(@"I navigate to the page ""(.*)""")]
        public void GivenINavigateToThePage(string p0)
        {
            GoogleHomePage GooglePage = new GoogleHomePage();
           
            
           

       

        }

        [Then(@"I Type in the Search Text box '(.*)'")]
        public void ThenITypeInTheSearchTextBox(string p0)
        {
            GoogleHomePage GooglePage = new GoogleHomePage();
            GooglePage.GoogleSearch();
            
        }




       

        [Then(@"I click on Search Button")]
        public void ThenIClickOnSearchButton()
        {
            GoogleHomePage GooglePage = new GoogleHomePage();
            GooglePage.Clicksearchbtn();
            
        }


      

        [Then(@"validate how many Gumtree links there are available")]
        public void ThenValidateHowManyGumtreeLinksThereAreAvailable()
        {
            Assert.AreEqual("www.gumtree.com › Motors", PropertiesCollections.driver.FindElement(By.XPath("//div[@class='TbwUpd NJjxre']//cite[@class='iUh30 bc tjvcx'][contains(text(),'www.gumtree.com')]")).Text);
        }

        [Then(@"Navigate to each Gumtree link")]
        public void ThenNavigateToEachGumtreeLink()
        {
            GoogleHomePage GooglePage = new GoogleHomePage();
            Thread.Sleep(5000);
            GoogleSearchResultPage searchResultPage = new GoogleSearchResultPage();
            searchResultPage.NavigateToGumtreeLink();
        }

        [Then(@"Confirm the title is displayed")]
        public void ThenConfirmTheTitleIsDisplayed()
        {
            Thread.Sleep(5000);
            //Assert.AreEqual("Gumtree", PropertiesCollections.driver.FindElement(By.XPath("//div[@class='gumtree-text-svg hide-fully-to-s']")).Text);

            Assert.AreEqual("Used Cars for Sale in London | Great Local Deals | Gumtree", PropertiesCollections.driver.Title);
        }


    }
}
