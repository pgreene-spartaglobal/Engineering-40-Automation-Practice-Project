using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class CheckoutPaymentPage
    {
        //COSMIN'S TERRITORY! TRESSPASS AT YOUR OWN RISK!
        private IWebDriver driver;

        public CheckoutPaymentPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/h1")]
        private IWebElement PaymentHeader;

        [FindsBy(How = How.XPath, Using = "//*[@id='HOOK_PAYMENT']/div[1]/div/p/a")]
        private IWebElement PayByBankWire;

        [FindsBy(How = How.LinkText, Using = "//*[@id='HOOK_PAYMENT']/div[2]/div/p/a")]
        private IWebElement PayByCheck;

        public void PayByBankWireButton()
        {
            PayByBankWire.Click();
        }
        public void PayByCheckButton()
        {
            PayByCheck.Click();
        }
        //Get the Payment Header
        public string PaymentHeaderResult()
        {
            return PaymentHeader.Text;
        }
    }
}
