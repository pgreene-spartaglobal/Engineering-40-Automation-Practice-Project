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
        private CheckoutPage checkoutpage;

        [Given(@"I am on the checkout page")]
        public void GivenIAmOnTheCheckoutPage()
        {
            driver = new ChromeDriver();
            checkoutpage = new CheckoutPage(driver);
            checkoutpage.GoToPage();
        }

        [Given(@"I have added a product to the Basket")]
        public void GivenIHaveAddedAProductToTheBasket()
        {
            checkoutpage.AddToCardButton();
        }
        
        [Given(@"I have navigated to the Checkout area")]
        public void GivenIHaveNavigatedToTheCheckoutArea()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the plus button")]
        public void WhenIClickThePlusButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see Quantity increase")]
        public void ThenIShouldSeeQuantityIncrease()
        {
            ScenarioContext.Current.Pending();
        }
        [AfterScenario]
        public void DisposeWebDriver()
        {
            driver.Close();
        }
    }
}
