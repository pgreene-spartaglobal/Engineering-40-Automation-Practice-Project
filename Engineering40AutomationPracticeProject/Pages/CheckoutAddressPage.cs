using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class CheckoutAddressPage
    {
        //COSMIN'S TERRITORY! TRESSPASS AT YOUR OWN RISK!
        private IWebDriver driver;

        public CheckoutAddressPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/h1")]
        private IWebElement AddressesHeader;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/form/p/button")]
        private IWebElement ProceedToCheckOutAddress;

        //Get the Addresses Header
        public string AddressesHeaderResult()
        {
            return AddressesHeader.Text;
        }

        public void ProceedToCheckOutButtonAddress()
        {
            ProceedToCheckOutAddress.Click();
        }
    }
}
