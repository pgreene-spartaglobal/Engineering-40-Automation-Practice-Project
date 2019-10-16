using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class ItemsInCartSteps
    {
        private IWebDriver driver;
        private Homepage homepage;
        private CartPage cartPage;
        private ProductPage product;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homepage = new Homepage(driver);
            cartPage = new CartPage(driver);
            product = new ProductPage(driver);
        }

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            homepage.GoToPage();
        }

        [When(@"I click on Cart")]
        public void WhenIClickOnCart()
        {
            homepage.GoToShoppingCart();
        }

        [Then(@"I should see the items in the Cart")]
        public void ThenIShouldSeeTheItemsInTheCart()
        {
            
        }

        [Then(@"there should be a Cart message\.")]
        public void ThenThereShouldBeACartMessage_()
        {
            string result = cartPage.emptyShoppingCart();
            Assert.AreEqual("Your shopping cart is empty.", result);
        }

        [Then(@"delete the item from cart")]
        public void ThenDeleteTheItemFromCart()
        {
            cartPage.deleteCart();
        }
    }
}
