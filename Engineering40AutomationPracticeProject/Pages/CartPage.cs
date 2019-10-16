using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

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
