using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Engineering40AutomationPracticeProject
{
    [Binding]
    public class AddToCartSteps2
    {
        private IWebDriver driver;
        private Homepage homepage;
        private ProductPage product;

        [Scope(Feature = "AddToCart2")]
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homepage = new Homepage(driver);
            product = new ProductPage(driver);
        }

        [Scope(Feature = "AddToCart2")]
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            homepage.GoToPage();
        }


        [Scope(Feature = "AddToCart2")]
        [When(@"I press add to cart")]
        public void WhenIPressAddToCart()
        {
        }


        [Scope(Feature = "AddToCart2")]
        [Then(@"a pop-up window saying Successfully added to the cart should appear")]
        public void ThenAPop_UpWindowSayingSuccessfullyAddedToTheCartShouldAppear()
        {
            Thread.Sleep(3000);
            Assert.AreEqual("Product successfully added to your shopping cart", product.SuccessfulAddToTheCart());
        }
    }
}
