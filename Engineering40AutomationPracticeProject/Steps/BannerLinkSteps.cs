using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Engineering40AutomationPracticeProject.Pages;
using NUnit.Framework;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class BannerLinkSteps
    {
        private IWebDriver driver;
        HomePage homePage;

        [Scope(Feature = "BannerLink")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);         
        }

        [Given(@"I am on the home pages")]
        public void GivenIAmOnTheHomePages()
        {
            homePage.GoToPage();
        }


        [When(@"I click on the banner")]
        public void WhenIClickOnTheBanner()
        {
            
        }
        
       

        [Then(@"I should not be on the same page")]
        public void ThenIShouldNotBeOnTheSamePage()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
