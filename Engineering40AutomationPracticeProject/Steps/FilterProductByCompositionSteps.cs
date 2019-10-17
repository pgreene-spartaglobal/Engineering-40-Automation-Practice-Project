using System;
using TechTalk.SpecFlow;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class FilterProductByCompositionSteps
    {
        IWebDriver driver;
        ProductPage productPage;

        [Scope(Feature = "FilterProductByComposition")]
        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Scope(Feature = "FilterProductByComposition")]
        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
        }

        [Scope(Feature = "FilterProductByComposition")]
        [Given(@"I am on the Women Page")]
        public void GivenIAmOnTheWomenPage()
        {
            productPage = new WomenPage(driver);
            productPage.GoToPage();
        }

        [Scope(Feature = "FilterProductByComposition")]
        [When(@"I tick the Cotton check box")]
        public void WhenITickTheCottonCheckBox()
        {
            productPage.ClickCotton();
        }

        [Scope(Feature = "FilterProductByComposition")]
        [When(@"I tick the Polyester check box")]
        public void WhenITickThePolyesterCheckBox()
        {
            productPage.ClickPolyester();
        }

        [Scope(Feature = "FilterProductByComposition")]
        [When(@"I tick the Viscose check box")]
        public void WhenITickTheViscoseCheckBox()
        {
            productPage.ClickViscose();
        }

        [Scope(Feature = "FilterProductByComposition")]
        [Then(@"the result should be showing Cotton items")]
        public void ThenTheResultShouldBeShowingCottonItems()
        {
            ScenarioContext.Current.Pending();
        }

        [Scope(Feature = "FilterProductByComposition")]
        [Then(@"the result should be showing Polyester items")]
        public void ThenTheResultShouldBeShowingPolyesterItems()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be showing Viscose items")]
        public void ThenTheResultShouldBeShowingViscoseItems()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
