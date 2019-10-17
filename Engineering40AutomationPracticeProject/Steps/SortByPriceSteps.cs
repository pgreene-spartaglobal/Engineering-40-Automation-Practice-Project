using System;
using TechTalk.SpecFlow;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Engineering40AutomationPracticeProject.Pages
{


    [Binding]
    public class SortByPriceSteps
    {

        private IWebDriver driver;
        private ProductPage productPage;

        [Scope(Feature = "SortByPrice")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            
        }
        [Given(@"I am on the women page")]
        public void GivenIAmOnTheWomenPage()
        {
            productPage = new WomenPage(driver);
            productPage.GoToPage();
        }
        
        [When(@"I click on price lowest first")]
        public void WhenIClickOnPriceLowestFirst()
        {
            productPage.ClickDropDownPrice(1);
        }
        
        [When(@"I click on price highest first")]
        public void WhenIClickOnPriceHighestFirst()
        {
            productPage.ClickDropDownPrice(2);
        }
        
        [When(@"I click on product by A-Z")]
        public void WhenIClickOnProductByA_Z()
        {
            productPage.ClickDropDownPrice(3);
        }
        
        [When(@"I click on product by Z-A")]
        public void WhenIClickOnProductByZ_A()
        {
            productPage.ClickDropDownPrice(4);
        }
        
        [When(@"I click on in-stock")]
        public void WhenIClickOnIn_Stock()
        {
            productPage.ClickDropDownPrice(5);
        }
        
        [When(@"I click on reference - Lowest First")]
        public void WhenIClickOnReference_LowestFirst()
        {
            productPage.ClickDropDownPrice(6);
        }
        
        [When(@"I click on reference - Highest First")]
        public void WhenIClickOnReference_HighestFirst()
        {
            productPage.ClickDropDownPrice(7);
        }
        
        [Then(@"It should display items in ascending order by price")]
        public void ThenItShouldDisplayItemsInAscendingOrderByPrice()
        {
            Assert.IsTrue(productPage.CheckLowestFirst());
        }
        
        [Then(@"It should not display items in descending order by price")]
        public void ThenItShouldNotDisplayItemsInDescendingOrderByPrice()
        {
            Assert.IsTrue(productPage.CheckLowestFirst());
        }
        
        [Then(@"It should not display items in ascending order by product")]
        public void ThenItShouldNotDisplayItemsInAscendingOrderByProduct()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"It should not display items in descending order by product")]
        public void ThenItShouldNotDisplayItemsInDescendingOrderByProduct()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"It should display items that are in stock")]
        public void ThenItShouldDisplayItemsThatAreInStock()
        {
            Assert.AreEqual("In stock", productPage.ItemInStock());
        }
        
        [Then(@"It should not display items in ascending order by reference")]
        public void ThenItShouldNotDisplayItemsInAscendingOrderByReference()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"It should not display items in descending order by reference")]
        public void ThenItShouldNotDisplayItemsInDescendingOrderByReference()
        {
            ScenarioContext.Current.Pending();
        }

        [Scope(Feature = "SortByPrice")]
        [AfterScenario]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
