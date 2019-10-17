using System;
using TechTalk.SpecFlow;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            ScenarioContext.Current.Pending();
        }

        [Scope(Feature = "FilterProductByCategories")]
        [Then(@"the result should be showing the Dresses Items")]
        public void ThenTheResultShouldBeShowingTheDressesItems()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
