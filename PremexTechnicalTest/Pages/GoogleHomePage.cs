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
    public class GoogleHomePage

        
    {
        public GoogleHomePage()
        {
            PageFactory.InitElements(PropertiesCollections.driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement ClickSearchButton { get; set; }

        


        public void GoogleSearch()
        {
            SearchBox.SendKeys("Cars in London");
            Thread.Sleep(5000);
           
        }

        public void Clicksearchbtn()
        {
            ClickSearchButton.Click();
        }


        // Assert how many Gumtree links are available

      //  public void GumtreelinksAvalaibe()
       // {

       // }


       // Navigate to each Gumtree link

       

    }

    



}
