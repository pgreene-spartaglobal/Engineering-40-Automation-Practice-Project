using System;
using TechTalk.SpecFlow;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Engineering40AutomationPracticeProject
{
    [Binding]
    public class FilterProductByCategoriesSteps
    {
        IWebDriver driver;
        ProductPage productPage;

        [Scope(Feature = "FilterProductByCategories")]
        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Scope(Feature = "FilterProductByCategories")]
        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
        }

        [Scope(Feature = "FilterProductByCategories")]
        [Given(@"I am on the Women Page")]
        public void GivenIAmOnTheWomenPage()
        {
            productPage = new WomenPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByCategories")]
        [When(@"I tick the Tops check box")]
        public void WhenITickTheTopsCheckBox()
        {
            (productPage as WomenPage).ClickTops();
        }

        [Scope(Feature = "FilterProductByCategories")]
        [Then(@"the result should be showing the Tops items")]
        public void ThenTheResultShouldBeShowingTheTopsItems()
        {
            bool result = productPage.ContainName("T-shirts") | productPage.ContainName("blouse");
            Assert.AreEqual(true, result);
        }

        [Scope(Feature = "FilterProductByCategories")]
        [Then(@"the result should be showing the Dresses items")]
        public void ThenTheResultShouldBeShowingTheDressesItems()
        {
            bool result = productPage.ContainName("dress");
            Assert.AreEqual(true, result);
        }

        [Scope(Feature = "FilterProductByCategories")]
        [Given(@"I am on the Dresses Page")]
        public void GivenIAmOnTheDressesPage()
        {
            productPage = new DressesPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByCategories")]
        [When(@"I tick the Evening Dresses check box")]
        public void WhenITickTheEveningDressesCheckBox()
        {
            (productPage as DressesPage).ClickEveningDresses();
        }

        [Scope(Feature = "FilterProductByCategories")]
        [Then(@"the result should be showing the Summer Dresses items")]
        public void ThenTheResultShouldBeShowingTheSummerDressesItems()
        {
            bool result = productPage.ContainName("summer dress");
            Assert.AreEqual(true, result);
        }

        [Scope(Feature = "FilterProductByCategories")]
        [When(@"I tick the Summer Dresses check box")]
        public void WhenITickTheSummerDressesCheckBox()
        {
            (productPage as DressesPage).ClickSummerDresses();
        }

    }
}
