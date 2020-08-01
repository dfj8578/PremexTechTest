using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PremexTechnicalTest
{
    class GoogleSearchResultPage
    {
        public GoogleSearchResultPage()
        {
            PageFactory.InitElements(PropertiesCollections.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='TbwUpd NJjxre']//cite[@class='iUh30 bc tjvcx'][contains(text(),'www.gumtree.com')]")]
        public IWebElement GumtreeLink { get; set; }

        public GoogleSearchResultPage NavigateToGumtreeLink()
        {
            Thread.Sleep(2000);
            GumtreeLink.Click();

            // Return the page object

            return new GoogleSearchResultPage();
        }
    }
}
