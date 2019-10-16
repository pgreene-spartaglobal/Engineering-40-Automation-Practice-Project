using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class SetQuantitySteps
    {
        private IWebDriver driver;
        private CheckoutPage CheckoutPage;

        [Given(@"I am on the checkout page")]
        public void GivenIAmOnTheCheckoutPage()
        {
            driver = new ChromeDriver();
            CheckoutPage = new CheckoutPage(driver);
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
            
        }
        
        [Then(@"I should see Quantity increase")]
        public void ThenIShouldSeeQuantityIncrease()
        {
            
        }
    }
}
