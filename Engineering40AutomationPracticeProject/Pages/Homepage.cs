using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class Homepage
    {
        private readonly IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "product-image_link")]
        private readonly IWebElement GotoProduct;


        [FindsBy(How = How.ClassName, Using = "shopping_cart")]
        private readonly IWebElement GotoShoppingCart;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void ClickProduct()
        {
            GotoProduct.Click();
        }

        public void ClickCart()
        {
            GotoShoppingCart.Click();
        }
    }
}
