using Engineering40AutomationPracticeProject.Pages;
using Nest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class PurchasingSetQuantitySteps 
    {
        IWebDriver driver;
        CheckoutPage checkoutPage;

        [Scope(Feature = "SetQuantity")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            checkoutPage = new CheckoutPage(driver);
        }

        [Given(@"I am on the checkout page")]
        public void GivenIAmOnTheCheckoutPage()
        {
            
            checkoutPage.goToPage();
        }

        [Given(@"I have added a product to the Basket")]
        public void GivenIHaveAddedAProductToTheBasket()
        {
            checkoutPage.AddToCartButton();
        }
        
        [Given(@"I have navigated to the Checkout area")]
        public void GivenIHaveNavigatedToTheCheckoutArea()
        {
            checkoutPage.goToCheckoutPage();
        }
        
        [When(@"I click the plus button")]
        public void WhenIClickThePlusButton()
        {
            checkoutPage.ClickPlusButton();
            Thread.Sleep(4000);
        }

        [When(@"I click the minus button")]
        public void WhenIClickTheMinusButton()
        {
            checkoutPage.ClickPlusButton();
            Thread.Sleep(4000);
            checkoutPage.ClickMinusButton();
            Thread.Sleep(4000);

        }

        [Then(@"I should see Quantity increase")]
        public void ThenIShouldSeeQuantityIncrease()
        {
            Assert.AreEqual("2", checkoutPage.ReadNewQuantity().ToString());
        }

        [Then(@"I should see Quantity decrease")]
        public void ThenIShouldSeeQuantityDecrease()
        {

            Assert.AreEqual("1", checkoutPage.ReadNewQuantity().ToString());
        }


        [Scope(Feature = "SetQuantity")]
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}
