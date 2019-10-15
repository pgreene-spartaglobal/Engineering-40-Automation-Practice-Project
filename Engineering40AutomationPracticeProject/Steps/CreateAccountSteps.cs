using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class CreateAccountSteps
    {
        IWebDriver driver;
        Base ba;
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            driver = new ChromeDriver();
            ba = new Base(driver);
            ba.Navigate("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }
        [Given(@"I have entered an invalid email address")]
        public void GivenIHaveEnteredAnInvalidEmailAddress()
        {
            ba.createAccountEmail.SendKeys("");
        }
        
        [Given(@"I have clicked create account")]
        public void GivenIHaveClickedCreateAccount()
        {
            //ba.submitButton.Click();
        }
        
        [Given(@"I have entered a valid email address")]
        public void GivenIHaveEnteredAValidEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a valid email address and clicked create account")]
        public void GivenIHaveEnteredAValidEmailAddressAndClickedCreateAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a first name")]
        public void GivenIHaveEnteredAFirstName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a last name")]
        public void GivenIHaveEnteredALastName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered an address")]
        public void GivenIHaveEnteredAnAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a City")]
        public void GivenIHaveEnteredACity()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a valid state")]
        public void GivenIHaveEnteredAValidState()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a valid Postal code")]
        public void GivenIHaveEnteredAValidPostalCode()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a valid mobile phone")]
        public void GivenIHaveEnteredAValidMobilePhone()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not entered a first name")]
        public void GivenIHaveNotEnteredAFirstName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not entered a last name")]
        public void GivenIHaveNotEnteredALastName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not entered an address")]
        public void GivenIHaveNotEnteredAnAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not entered a City")]
        public void GivenIHaveNotEnteredACity()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not entered a valid state")]
        public void GivenIHaveNotEnteredAValidState()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not entered a valid Postal code")]
        public void GivenIHaveNotEnteredAValidPostalCode()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not entered a valid mobile phone")]
        public void GivenIHaveNotEnteredAValidMobilePhone()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not entered a city")]
        public void Ihavenotenteredacity()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not enterd a valid mobile phone")]
        public void GivenIHaveNotEnterdAValidMobilePhone()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will see the appropriate error for incorrect email format")]
        public void ThenIWillSeeTheAppropriateErrorForIncorrectEmailFormat()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will go to the relevant page to create an account")]
        public void ThenIWillGoToTheRelevantPageToCreateAnAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will be redirected to the account page")]
        public void ThenIWillBeRedirectedToTheAccountPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will see the appropriate error message for first name")]
        public void ThenIWillSeeTheAppropriateErrorMessageForFirstName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will see the appropriate error message for last name")]
        public void ThenIWillSeeTheAppropriateErrorMessageForLastName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will see the appropriate error message for address")]
        public void ThenIWillSeeTheAppropriateErrorMessageForAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will see the appropriate error message for city")]
        public void ThenIWillSeeTheAppropriateErrorMessageForCity()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will see the appropriate error message for state")]
        public void ThenIWillSeeTheAppropriateErrorMessageForState()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will see the appropriate error message for postal code")]
        public void ThenIWillSeeTheAppropriateErrorMessageForPostalCode()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will see the appropriate error message for mobile phone")]
        public void ThenIWillSeeTheAppropriateErrorMessageForMobilePhone()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will see the appropriate error message for all failure")]
        public void ThenIWillSeeTheAppropriateErrorMessageForAllFailure()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
