using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
        

        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=3&controller=category");
        }
        public void AddToCartButton(IWebDriver driver)
        {
            var AddToCart = driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div[2]/div[2]/a[1]"));
            Actions action = new Actions(driver);
            action.MoveToElement(AddToCart).Perform();
            AddToCart.Click();
        }

        public void goToCheckoutPage(IWebDriver driver)
        {
            var NavigateToCheckout = driver.FindElement(By.LinkText("http://automationpractice.com/index.php?controller=order"));
            NavigateToCheckout.Click();
            
        }
    }
}
