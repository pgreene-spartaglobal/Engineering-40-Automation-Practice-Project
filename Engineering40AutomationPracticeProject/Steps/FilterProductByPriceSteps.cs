using System;
using TechTalk.SpecFlow;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace Engineering40AutomationPracticeProject
{
    [Binding]
    public class FilterProductByPriceSteps
    {
        IWebDriver driver;
        ProductPage productPage;

        [Scope(Feature = "FilterProductByPrice")]
        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Scope(Feature = "FilterProductByPrice")]
        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
        }

        [Scope(Feature = "FilterProductByPrice")]
        [Given(@"I am on the Women Page")]
        public void GivenIAmOnTheWomenPage()
        {
            productPage = new WomenPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByPrice")]
        [Given(@"I am on the Dresses Page")]
        public void GivenIAmOnTheDressesPage()
        {
            productPage = new DressesPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByPrice")]
        [Given(@"I am on the T-Shirt Page")]
        public void GivenIAmOnTheT_ShirtPage()
        {
            productPage = new TShirtPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByPrice")]
        [Given(@"I am on the Casual Dresses Page")]
        public void GivenIAmOnTheCasualDressesPage()
        {
            productPage = new CasualDressesPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByPrice")]
        [Given(@"I am on the Summer Dresses Page")]
        public void GivenIAmOnTheSummerDressesPage()
        {
            productPage = new SummerDresses(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByPrice")]
        [Given(@"I am on the Evening Dresses Page")]
        public void GivenIAmOnTheEveningDressesPage()
        {
            productPage = new EveningDresses(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByPrice")]
        [When(@"I move the head of the slider to £(.*)")]
        public void WhenIMoveTheHeadOfTheSliderTo(double p0)
        {
            productPage.RangeSlider();
        }

        [Scope(Feature = "FilterProductByPrice")]
        [Then(@"result should be showing products that is below £(.*)")]
        public void ThenResultShouldBeShowingProductsThatIsBelow(double p0)
        {
            bool result = productPage.PriceOutOfRange(34.13, 53.00);
            Assert.AreEqual(true, result);   
        }
    }
}
