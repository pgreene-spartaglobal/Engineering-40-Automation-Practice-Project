using Engineering40AutomationPracticeProject.Pages;
using Nest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class SetQuantitySteps
    {
        IWebDriver driver;
        CheckoutPage CheckoutPage;

        [Scope(Feature = "SetQuantity")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            CheckoutPage = new CheckoutPage(driver);
        }

        [Given(@"I am on the checkout page")]
        public void GivenIAmOnTheCheckoutPage()
        {
            
            CheckoutPage.goToPage();
        }

        [Given(@"I have added a product to the Basket")]
        public void GivenIHaveAddedAProductToTheBasket()
        {
            CheckoutPage.AddToCartButton(driver);
        }
        
        [Given(@"I have navigated to the Checkout area")]
        public void GivenIHaveNavigatedToTheCheckoutArea()
        {
            CheckoutPage.goToCheckoutPage(driver);
        }
        
        [When(@"I click the plus button")]
        public void WhenIClickThePlusButton()
        {
            CheckoutPage.ClickPlussButton(driver);
        }
        
        [Then(@"I should see Quantity increase")]
        public void ThenIShouldSeeQuantityIncrease()
        {
            Thread.Sleep(10000);
            driver.Close();
        }

        [Scope(Feature = "SetQuantity")]
        [AfterScenario]
        public void AfterScenario()
        {
            
        }
    }
}
