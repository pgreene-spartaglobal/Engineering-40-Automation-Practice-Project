using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class AddToCart3Steps
    {
        private IWebDriver driver;
        private Homepage homepage;
        private ProductPage product;

        [Scope(Feature = "AddToCart3")]
        [BeforeScenario]
        public void BeforeScenario()
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

        [Given(@"hover on the product")]
        public void GivenHoverOnTheProduct()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have click on the quickview")]
        public void GivenIHaveClickOnTheQuickview()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have chosen the colour")]
        public void GivenIHaveChosenTheColour()
        {
            product.ChooseColour();
        }

        [Given(@"I have picked the size")]
        public void GivenIHavePickedTheSize()
        {
            product.ChooseSize("M");
        }

        [Given(@"I have added the quantity")]
        public void GivenIHaveAddedTheQuantity()
        {
            product.clearQuant();
            product.ChooseQuant("55");
        }

        [When(@"I press the add to the cart button")]
        public void WhenIPressTheAddToTheCartButton()
        {
            product.AddToCart1();
        }

        [Then(@"I should be able to to see the item added to the cart")]
        public void ThenIShouldBeAbleToToSeeTheItemAddedToTheCart()
        {
            Thread.Sleep(3000);
            Assert.AreEqual("Product successfully added to your shopping cart", product.SuccessfulAddToTheCart());
        }

        [Scope(Feature = "AddToCart3")]
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}
