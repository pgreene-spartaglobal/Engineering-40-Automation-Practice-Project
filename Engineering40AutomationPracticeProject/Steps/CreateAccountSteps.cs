using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium.Support.UI;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class CreateAccountSteps
    {
        IWebDriver driver;
        LoginPage lp;
        CreateAccountPage cap;
        [Given(@"I have entered an invalid email address")]
        public void GivenIHaveEnteredAnInvalidEmailAddress()
        {
            lp.createAccountEmail.SendKeys("");
        }
        
        [Given(@"I have clicked create account")]
        public void GivenIHaveClickedCreateAccount()
        {
            lp.submitCreateButton.Click();
        }
        
        [Given(@"I have entered a valid email address")]
        public void GivenIHaveEnteredAValidEmailAddress()
        {
            lp.createAccountEmail.SendKeys("john@admin.com");
        }
        
        [Given(@"I have entered a valid email address and clicked create account")]
        public void GivenIHaveEnteredAValidEmailAddressAndClickedCreateAccount()
        {
            driver = new ChromeDriver();
            cap = new CreateAccountPage(driver);
            cap.CreateAccount();

        }
        
        [Given(@"I have entered a first name")]
        public void GivenIHaveEnteredAFirstName()
        {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id("customer_firstname")));
            cap.firstNameField.SendKeys("John");
        }
        
        [Given(@"I have entered a last name")]
        public void GivenIHaveEnteredALastName()
        {
            cap.lastNameField.SendKeys("Admin");
        }
        
        [Given(@"I have entered an address")]
        public void GivenIHaveEnteredAnAddress()
        {
            cap.addressOneField.SendKeys("Yellow Brick Road");
        }
        
        [Given(@"I have entered a City")]
        public void GivenIHaveEnteredACity()
        {
            cap.cityField.SendKeys("Emerald City");
        }
        
        [Given(@"I have entered a valid state")]
        public void GivenIHaveEnteredAValidState()
        {
            cap.stateField.SendKeys("Kansas");
        }
        
        [Given(@"I have entered a valid Postal code")]
        public void GivenIHaveEnteredAValidPostalCode()
        {
            cap.postalcodeField.SendKeys("00000");
        }
        
        [Given(@"I have entered a valid mobile phone")]
        public void GivenIHaveEnteredAValidMobilePhone()
        {
            cap.mobilephoneField.SendKeys("1066");
        }
        
        [Given(@"I have not entered a first name")]
        public void GivenIHaveNotEnteredAFirstName()
        {
            cap.firstNameField.SendKeys("");
        }
        
        [Given(@"I have not entered a last name")]
        public void GivenIHaveNotEnteredALastName()
        {
            cap.lastNameField.SendKeys("");
        }
        
        [Given(@"I have not entered an address")]
        public void GivenIHaveNotEnteredAnAddress()
        {
            cap.addressOneField.SendKeys("");
        }
        
        [Given(@"I have not entered a City")]
        public void GivenIHaveNotEnteredACity()
        {
            cap.cityField.SendKeys("");
        }
        
        [Given(@"I have not entered a valid state")]
        public void GivenIHaveNotEnteredAValidState()
        {
            cap.stateField.SendKeys("");
        }
        
        [Given(@"I have not entered a valid Postal code")]
        public void GivenIHaveNotEnteredAValidPostalCode()
        {
            cap.postalcodeField.SendKeys("");
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
