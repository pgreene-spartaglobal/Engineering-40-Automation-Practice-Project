using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class PurchasingPayByBankWirePage
    {
        private IWebDriver driver;

        public PurchasingPayByBankWirePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/h1")]
        private IWebElement OrderSummary;

        [FindsBy(How = How.XPath, Using = "//*[@id='cart_navigation']/button")]
        private IWebElement IConfirmMyOrder;

        public void PayByBankWireButton()
        {
            IConfirmMyOrder.Click();
        }
        public string OrderSummaryResult()
        {
            return OrderSummary.Text;
        }
    }
}
