using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class PurchasingPayByCheckOrderConfirmationPage
    {
        private IWebDriver driver;

        public PurchasingPayByCheckOrderConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/p[1]")]
        private IWebElement OrderConfirmation;

        //Get the OrderConfirmation Header
        public string OrderConfirmationResult()
        {
            return OrderConfirmation.Text;
        }
    }
}
