using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace Engineering40AutomationPracticeProject.Pages
{
    class Homepage
    {
        private IWebDriver driver;
        OpenQA.Selenium.Interactions.Actions actions;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            actions = new OpenQA.Selenium.Interactions.Actions(driver);
            PageFactory.InitElements(driver, this);
        }

       
        [FindsBy(How = How.ClassName, Using = "alert")]
        private IWebElement hoverelement;

        public void Hover()
        {
            actions.MoveToElement(hoverelement);
            actions.Click().Build().Perform();
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void GoToProduct()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_product=1&controller=product");
        }

        public void GoToShoppingCart()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=order");

        }
    }
}
