using System;
using TechTalk.SpecFlow;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class ShareItemsOverSocialMediaSteps
    {
        private IWebDriver driver;
        private DressesPage dressesPage;
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            dressesPage = new DressesPage(driver);
        }
        [Given(@"I am on the Dresses Page")]
        public void GivenIAmOnTheDressesPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected an Item")]
        public void GivenIHaveSelectedAnItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the facebook button")]
        public void WhenIClickOnTheFacebookButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the twitter button")]
        public void WhenIClickOnTheTwitterButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the google\+ button")]
        public void WhenIClickOnTheGoogleButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the pinterest button")]
        public void WhenIClickOnThePinterestButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be redirected to facebook to post about my Item")]
        public void ThenIShouldBeRedirectedToFacebookToPostAboutMyItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be redirected to twitter to post about my Item")]
        public void ThenIShouldBeRedirectedToTwitterToPostAboutMyItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be redirected to google\+ to post about my Item")]
        public void ThenIShouldBeRedirectedToGoogleToPostAboutMyItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be redirected to pinterest to post about my Item")]
        public void ThenIShouldBeRedirectedToPinterestToPostAboutMyItem()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
