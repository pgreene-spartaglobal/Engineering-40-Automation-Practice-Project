using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium.Support.UI;

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
            product.ChooseColour();
        }

        [Given(@"I have picked the size")]
        public void GivenIHavePickedTheSize()
        {
            product.ChooseSize("S");
        }

        [Given(@"I have added the quantity")]
        public void GivenIHaveAddedTheQuantity()
        {
            product.ChooseQuant("1");
        }

        [When(@"I press the add to the cart button")]
        public void WhenIPressTheAddToTheCartButton()
        {
            product.AddToCart1();
        }

        [Then(@"I should be able to to see the item added to the cart")]
        public void ThenIShouldBeAbleToToSeeTheItemAddedToTheCart()
        {
            Assert.IsTrue(product.CheckSuccess());
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            driver.Close();
        }
    }
}
