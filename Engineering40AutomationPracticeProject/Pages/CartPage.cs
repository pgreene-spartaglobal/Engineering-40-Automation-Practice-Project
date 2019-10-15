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

        [FindsBy(How = How.ClassName, Using = "ShoppingCart")]
        private IWebElement GotoShoppingCart;

        [FindsBy(How = How.ClassName, Using = "alert-warning")]
        private IWebElement EmptyShoppingCart;

        [FindsBy(How = How.ClassName, Using = "cart_summary")]
        private IWebElement CartSummary;

        public void GoToShoppingCart()
        {
            GotoShoppingCart.Click();
        }

        public string emptyShoppingCart()
        {
            return EmptyShoppingCart.Text;
        }
    }
}
