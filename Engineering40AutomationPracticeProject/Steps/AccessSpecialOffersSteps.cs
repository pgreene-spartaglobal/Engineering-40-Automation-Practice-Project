using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Engineering40AutomationPracticeProject.Pages;
using NUnit.Framework;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class AccessSpecialOffersSteps
    {
        IWebDriver driver;
        HomePage homePage;
        SpecialOfferPage specialPage;


        [Scope(Feature = "AccessSpecialOffers")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
            specialPage = new SpecialOfferPage(driver);
        }

        [Given(@"I am in the home page")]
        public void GivenIAmInTheHomePage()
        {
            homePage.GoToPage();
        }
        
        [When(@"I click on the special offer page")]
        public void WhenIClickOnTheSpecialOfferPage()
        {
            homePage.Special();
        }
        
        [Then(@"It should show me the special offers")]
        public void ThenItShouldShowMeTheSpecialOffers()
        {
            Assert.AreEqual("http://automationpractice.com/index.php?controller=prices-drop", homePage.SpecialUrl());
        }

        [Given(@"I am in the special offer page")]
        public void GivenIAmInTheSpecialOfferPage()
        {
            specialPage.GoToPage();
        }

        [When(@"I compare the original and the new price")]
        public void WhenICompareTheOriginalAndTheNewPrice()
        {
            specialPage.ComparePrice();
        }

        [Then(@"The new price should be less than the original price")]
        public void ThenTheNewPriceShouldBeLessThanTheOriginalPrice()
        {
            Assert.IsTrue(specialPage.checkSpecialPriceValidity());
            //Assert.AreEqual(" ", specialPage.checkSpecialPriceValidity());
        }

        [Scope(Feature = "AccessSpecialOffers")]
        [AfterScenario]
        public void CleanUp()
        {
            driver.Close();
            
        }
    }
}
