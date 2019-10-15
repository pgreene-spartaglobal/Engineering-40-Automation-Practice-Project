using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;

namespace Engineering40AutomationPracticeProject
{
    [Binding]
    public class AddToCartSteps
    {
        private IWebDriver driver;
        private Homepage homepage;
        private ProductPage product;

        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homepage = new Homepage(driver);
            product = new ProductPage(driver);
        }

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            homepage.GoToPage();
        }
        
        [Given(@"I have opted an item")]
        public void GivenIHaveOptedAnItem()
        {
            homepage.GoToProduct();
        }

        [Given(@"I have chosen the colour")]
        public void GivenIHaveChosenTheColour()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have picked the size")]
        public void GivenIHavePickedTheSize()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have added the quantity")]
        public void GivenIHaveAddedTheQuantity()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press the add to the cart button")]
        public void WhenIPressTheAddToTheCartButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to to see the item added to the cart")]
        public void ThenIShouldBeAbleToToSeeTheItemAddedToTheCart()
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
