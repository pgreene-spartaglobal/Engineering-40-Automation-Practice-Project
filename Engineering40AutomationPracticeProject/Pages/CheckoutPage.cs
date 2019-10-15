using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineering40AutomationPracticeProject.Pages
{
    class CheckoutPage
    {
        private IWebDriver driver;

        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Women")]
        private IWebElement WomenPageLink;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
    }
}
