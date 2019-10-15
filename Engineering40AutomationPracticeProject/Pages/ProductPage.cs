using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class ProductPage
    {
        private readonly IWebDriver driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "quantity_wanted")]
        private readonly IWebElement EnterQuantity;

        [FindsBy(How = How.Id, Using = "group_1")]
        private readonly IWebElement SelectSize;

        [FindsBy(How = How.ClassName, Using = "color_pick selected")]
        private readonly IWebElement ChooseColor;

        [FindsBy(How = How.Id, Using = "add_to_cart")]
        private readonly IWebElement AddToCart;


        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_product=1&controller=product");
        }
    }
}
