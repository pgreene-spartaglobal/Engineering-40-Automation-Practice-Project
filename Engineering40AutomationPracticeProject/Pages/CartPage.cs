using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Engineering40AutomationPracticeProject.Pages
{
    class CartPage
    {
        private IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/p")]
        private IWebElement EmptyShoppingCart;

        [FindsBy(How = How.Id, Using = "summary_products_quantity")]
        private IWebElement CartSummary;

        [FindsBy(How = How.ClassName, Using = "cart_quantity_input")]
        private IWebElement QtySummary;

        [FindsBy(How = How.ClassName, Using = "cart_quantity_delete")]
        private IWebElement DeleteCart;

        [FindsBy(How = How.XPath, Using = "//*[@id='layer_cart']/div[1]/div[2]/div[4]/a")]
        private IWebElement ProcessCheckout;

        public void ProcessButton()
        {
            WebDriverWait confirmCheckout = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            confirmCheckout.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a")));
            ProcessCheckout.Click();
        }
        public string emptyShoppingCart()
        {
            return EmptyShoppingCart.Text;
        }

        public string ShoppingCartContains()
        {
            return CartSummary.Text;
        }

        public string QtyCartContains()
        {
            return QtySummary.GetAttribute("value");
        }

        public void deleteCart()
        {
            DeleteCart.Click();
        }
    }
}
