using Nest;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        [FindsBy(How = How.ClassName, Using = "cart_quantity_up")]
        private IWebElement QuantityUp;

        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=3&controller=category");
        }
        public void AddToCartButton(IWebDriver driver)
        {
            var AddToCart = driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div[2]/div[2]/a[1]"));
            Thread.Sleep(2000);
            AddToCart.Click();
        }

        public void goToCheckoutPage(IWebDriver driver)
        {
            var CheckoutPage = driver.FindElement(By.LinkText("Proceed to checkout"));
        }

        public void ClickPlussButton(IWebDriver driver)
        {
            QuantityUp.Click();
        }

        public string ReadNewQuantity(IWebDriver driver)
        {
            var QuantityResult = driver.FindElement(By.ClassName("cart_quantity_input"));
            return QuantityResult.Text;
        }


    }
}
