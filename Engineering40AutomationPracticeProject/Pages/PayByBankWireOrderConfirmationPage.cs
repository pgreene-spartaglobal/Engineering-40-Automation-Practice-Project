using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class PayByBankWireOrderConfirmationPage
    {
        //COSMIN'S TERRITORY! TRESSPASS AT YOUR OWN RISK!
        private IWebDriver driver;

        public PayByBankWireOrderConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/h1")]
        private IWebElement OrderConfirmation;

        //Get the OrderConfirmation Header
        public string OrderConfirmationResult()
        {
            return OrderConfirmation.Text;
        }
    }
}
