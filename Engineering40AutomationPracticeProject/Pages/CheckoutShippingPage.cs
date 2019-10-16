using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class CheckoutShippingPage
    {
        //COSMIN'S TERRITORY! TRESSPASS AT YOUR OWN RISK!
        private IWebDriver driver;

        public CheckoutShippingPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='carrier_area']/h1")]
        private IWebElement ShippingHeader;
        
        [FindsBy(How = How.Id, Using = "cgv")]
        private IWebElement CheckBoxShipping;

        [FindsBy(How = How.XPath, Using = "//*[@id='form']/p/button")]
        private IWebElement ProceedToCheckOutShipping;
        

        //Get the Shipping Header
        public string ShippingHeaderResult()
        {
            return ShippingHeader.Text;
        }

        public void CheckBoxButtonShipping()
        {
            CheckBoxShipping.Click();
        }

        public void ProceedToCheckOutButtonAddress()
        {
            ProceedToCheckOutShipping.Click();
        }
    }
}
