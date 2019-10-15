using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class LoginToAccountSteps
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

        [Given(@"I have entered a correct password")]
        public void GivenIHaveEnteredACorrectPassword()
        {
            ba.passwordField.SendKeys("PAssword");
        }
        
        [Given(@"I have entered a correct email address")]
        public void GivenIHaveEnteredACorrectEmailAddress()
        {
            ba.emailField.SendKeys("steve@admin.com");
        }
        
        [Given(@"I have entered an incorrect email address")]
        public void GivenIHaveEnteredAnIncorrectEmailAddress()
        {
            ba.emailField.SendKeys("john@admin.com");
        }

        [Given(@"I have entered an incorrect password")]
        public void GivenIHaveEnteredAnIncorrectPassword()
        {
            ba.passwordField.SendKeys("Null");
        }
        [Given(@"I have clicked the submit button")]
        public void Ihaveclickerthesubmitbutton()
        {
            ba.submitButton.Click();
        }
        [Then(@"I will be redirected to the account page")]
        public void Iwillberedirectedtotheaccountpage()
        {
            Assert.AreEqual("http://automationpractice.com/index.php?controller=my-account", driver.Url);
        }
        
        [Then(@"I will see the appropriate error message for email")]
        public void Iwillseetheappropriateerrormessageforemail()
        {
            Assert.AreEqual("Authentication failed.", ba.AuthenticateError.Text);
        }
        [Then(@"I will see the appropriate error message for password")]
        public void Iwillseetheappropriateerrormessageforepassword()
        {
            Assert.AreEqual("Invalid password.", ba.AuthenticateError.Text);
        }
        [AfterScenario]
        public void DisposeWebDriver()
        {
            driver.Close();
        }
    }
}
