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

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/form/div/p/a")]
        private IWebElement AddAddress;

        [FindsBy(How = How.XPath, Using = "//*[@id='address_delivery']/li[7]/a")]
        private IWebElement UpdateDeliveryAddress;

        [FindsBy(How = How.XPath, Using = "//*[@id='address_invoice']/li[7]/a")]
        private IWebElement UpdateBillingAddress;
        
        //Get the Addresses Header
        public string AddressesHeaderResult()
        {
            return AddressesHeader.Text;
        }

        public void ProceedToCheckOutButtonAddress()
        {
            ProceedToCheckOutAddress.Click();
        }
        public void AddAddressButtonCheckout()
        {
            AddAddress.Click();
        }
        public void UpdateDeliveryAddressButtonCheckout()
        {
            UpdateDeliveryAddress.Click();
        }
        public void UpdateBillingAddressButtonCheckout()
        {
            UpdateBillingAddress.Click();
        }
    }
}
