using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class SortByPriceSteps
    {
        
        private IWebDriver driver;
        private WomenPage womenPage;

        [Scope(Feature = "SortByPrice")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            womenPage = new WomenPage(driver);
        }

        [Given(@"I am on the women page")]
        public void GivenIAmOnTheWomenPage()
        {
            womenPage.GoToPage();
        }
        
        [When(@"I click on the price range bar")]
        public void WhenIClickOnThePriceRangeBar()
        {
            womenPage.RangeSlider();
        }
        
        [Then(@"It should display the buffering icon")]
        public void ThenItShouldDisplayTheBufferingIcon()
        {
            Assert.IsTrue(womenPage.BufferImg());
        }

        [Scope(Feature = "SortByPrice")]
        [AfterScenario]
        public void DisposeWebDriver()
        {
            driver.Close();
        }
    }
}
