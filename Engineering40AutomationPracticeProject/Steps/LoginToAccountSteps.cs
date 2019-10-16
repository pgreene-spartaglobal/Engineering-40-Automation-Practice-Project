using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class LoginToAccountSteps
    {
        IWebDriver driver;
        LoginPage lp;
        MyAccountPage ap;
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            driver = new ChromeDriver();
            lp = new LoginPage(driver);
            ap = new MyAccountPage(driver);
            lp.Navigate("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }

        [Given(@"I have entered a correct password")]
        public void GivenIHaveEnteredACorrectPassword()
        {
            lp.passwordField.SendKeys("PAssword");
        }
        
        [Given(@"I have entered a correct email address")]
        public void GivenIHaveEnteredACorrectEmailAddress()
        {
            lp.emailField.SendKeys("steve@admin.com");
        }
        
        [Given(@"I have entered an incorrect email address")]
        public void GivenIHaveEnteredAnIncorrectEmailAddress()
        {
            lp.emailField.SendKeys("john@admin.com");
        }

        [Given(@"I have entered an incorrect password")]
        public void GivenIHaveEnteredAnIncorrectPassword()
        {
            lp.passwordField.SendKeys("Null");
        }
        [Given(@"I have clicked the submit button")]
        public void GivenIHaveClickedTheSubmitButton()
        {
            lp.submitLoginButton.Click();
        }
        [Then(@"I will be redirected to the account page")]
        public void ThenIWillBeRedirectedToTheAccountPage()
        {
            Assert.AreEqual("http://automationpractice.com/index.php?controller=my-account", driver.Url);
        }
        
        [Then(@"I will see the appropriate error message for email")]
        public void ThenIWillSeeTheAppropriateErrorMessageForEmail()
        {
            Assert.AreEqual("Authentication failed.", lp.AuthenticateError.Text);
        }
        [Then(@"I will see the appropriate error message for password")]
        public void ThenIWillSeeTheAppropriateErrorMessageForPassword()
        {
            Assert.AreEqual("Invalid password.", lp.AuthenticateError.Text);
        }
        [Then(@"I will see my account name in the nav header")]
        public void IWillSeeMyAccountNameInTheNavHeader()
        {
            Assert.AreEqual("Steve Admin", ap.GetAccountHeader());
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            driver.Close();
        }
    }
}
