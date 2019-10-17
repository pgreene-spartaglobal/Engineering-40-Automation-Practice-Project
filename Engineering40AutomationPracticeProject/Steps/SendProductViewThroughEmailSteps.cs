using System;
using TechTalk.SpecFlow;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class SendProductViewThroughEmailSteps
    {
        IWebDriver chromeDriver;
        ProductViewPage productViewPage;

        [Scope(Feature = "SendProductViewThroughEmail")]
        [BeforeScenario]
        public void SetUp()
        {
            chromeDriver = new ChromeDriver();
            productViewPage = new ProductViewPage(chromeDriver);
        }

        [Given(@"I am in a product view page")]
        public void GivenIAmInAProductViewPage()
        {
            productViewPage.GoToPage();
        }
        
        [When(@"I click on the send to a friend link")]
        public void WhenIClickOnTheSendToAFriendLink()
        {
            productViewPage.ClickOnSendToFriend();
        }
        
        [When(@"I have entered a name")]
        public void WhenIHaveEnteredAName()
        {
            productViewPage.EnterName();
        }
        
        [When(@"I have entered an invalid email")]
        public void WhenIHaveEnteredAnInvalidEmail()
        {
            productViewPage.EnterInvalidEmail();
        }

        [When(@"I click the send button")]
        public void WhenIClickTheSendButton()
        {
            productViewPage.ClickSend();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }


        [Then(@"The mail should not be sent")]
        public void ThenTheMailShouldNotBeSent()
        {
            Assert.AreEqual("Your e-mail has been sent successfully", productViewPage.GetResultText());
        }

        [Scope(Feature = "SendProductViewThroughEmail")]
        [AfterScenario]
        public void CleanUp()
        {
            chromeDriver.Close();
        }
    }
}
