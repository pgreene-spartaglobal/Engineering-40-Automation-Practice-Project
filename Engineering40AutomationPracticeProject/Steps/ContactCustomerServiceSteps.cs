using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Engineering40AutomationPracticeProject.Pages;
using NUnit.Framework;



namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class ContactCustomerServiceSteps
    {
        IWebDriver driver;
        ContactsPage contactPage;

        [Scope(Feature = "ContactCustomerService")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            contactPage = new ContactsPage(driver);
        }

        [Given(@"I am at the contact page")]
        public void GivenIAmAtTheContactPage()
        {
            contactPage.GoToPage();
        }
        
        [Given(@"I have chosen the customer service as subject heading")]
        public void GivenIHaveChosenTheCustomerServiceAsSubjectHeading()
        {
            contactPage.SelectSubjectHeading();
        }
        
        [Given(@"I have entered a valid email address")]
        public void GivenIHaveEnteredAValidEmailAddress()
        {
            contactPage.EmailField();
        }
        
        [Given(@"I have entered a message")]
        public void GivenIHaveEnteredAMessage()
        {
            contactPage.EnterMessage();
        }
        
        [When(@"I click on send")]
        public void WhenIClickOnSend()
        {
            contactPage.ClickSend();
        }
        
        [Then(@"It should display a message sent text")]
        public void ThenItShouldDisplayAMessageSentText()
        {
            Assert.AreEqual("Your message has been successfully sent to our team.", contactPage.GetDisplayedMessage());
        }

        [Scope(Feature = "ContactCustomerService")]
        [AfterScenario]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
