using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Engineering40AutomationPracticeProject.Pages
{
    [Binding]
    public class NavigationSteps
    {
        private IWebDriver driver;
        private HomePage homePage;

        [Scope(Feature = "Navigation")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
        }

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            homePage.GoToPage();
        }
        
        [When(@"I press the Women button")]
        public void WhenIPressTheWomenButton()
        {
            homePage.WomenTab();          
        }
        
        [When(@"I press the Dresses button")]
        public void WhenIPressTheDressesButton()
        {
            homePage.DressesTab();
        }
        
        [When(@"I press T-Shirts button")]
        public void WhenIPressT_ShirtsButton()
        {
            homePage.TShirtTab();
        }
        
        [Then(@"I should see the Women page")]
        public void ThenIShouldSeeTheWomenPage()
        {
            Assert.AreEqual("Women - My Store", driver.Title);
        }
        
        [Then(@"I should see the Dresses page")]
        public void ThenIShouldSeeTheDressesPage()
        {
            Assert.AreEqual("Dresses - My Store", driver.Title);
        }
        
        [Then(@"I should see the T-Shirts page")]
        public void ThenIShouldSeeTheT_ShirtsPage()
        {
            Assert.AreEqual("T-shirts - My Store", driver.Title);
        }

        [Scope(Feature = "Navigation")]
        [AfterScenario]
        public void DisposeWebDriver()
        {
            driver.Close();
        }
    }
}
