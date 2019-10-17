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
using OpenQA.Selenium.Support.UI;
namespace Engineering40AutomationPracticeProject.Pages
{
    class PurchasingCheckoutPage
    {
        private IWebDriver driver;

        public PurchasingCheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=3&controller=category");
        }
        public void AddToCartButton()
        {
            var AddToCart = driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div[2]/div[2]/a[1]"));
            Thread.Sleep(2000);
            AddToCart.Click();
        }

        public void goToCheckoutPage()
        {
            var CheckoutPage = driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a"));
            WebDriverWait confirmCheckout = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            confirmCheckout.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a")));
            CheckoutPage.Click();

        }

        public void ClickPlusButton()
        {
            var QuantityPlus = driver.FindElement(By.Id("cart_quantity_up_1_1_0_0"));
            QuantityPlus.Click();
        }

        public void ClickMinusButton()
        {
            var QuantityMinus = driver.FindElement(By.Id("cart_quantity_down_1_1_0_0"));
            QuantityMinus.Click();
        }

        public string ReadNewQuantity()
        {
            var QuantityResult = driver.FindElement(By.ClassName("cart_quantity_input"));
            return QuantityResult.GetAttribute("value");
        }


    }
}
