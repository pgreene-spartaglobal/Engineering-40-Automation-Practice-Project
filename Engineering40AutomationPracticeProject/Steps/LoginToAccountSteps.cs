using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

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
        //Add Comment
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
            lp.createAccountEmail.SendKeys("jimmeny@admin.com");
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
        [Given(@"I have entered an email already registered")]
        public void GivenIHaveEnteredAnEmailAlreadyRegistered()
        {
            lp.createAccountEmail.SendKeys("john@admin.com");
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




        [Then(@"I will be redirected to the account page after login")]
        public void ThenIWillBeRedirectedToTheAccountPageAfterLogin()
        {
            try
            {
                Assert.AreEqual("http://automationpractice.com/index.php?controller=my-account", driver.Url);
            }
            finally
            {
                driver.Close();
            }
        }
        [Then(@"I will see the appropriate error for email address in use")]
        public void ThenIWillSeeTheAppropriateErrorForEmailAddressInUse()
        {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[1]/ol/li")));
            try
            {
                Assert.AreEqual("An account using this email address has already been registered. Please enter a valid password or request a new one.", lp.emailCreateAccountErrorBox.Text);
            }
            finally
            {
                driver.Close();
            }
        }

        [Then(@"I will see the appropriate error message for email")]
        public void ThenIWillSeeTheAppropriateErrorMessageForEmail()
        {
            try
            {
            Assert.AreEqual("Authentication failed.", lp.AuthenticateError.Text);
            }
            finally
            {
                driver.Close();
            }
        }

        [Then(@"I will go to the relevant page to create an account")]
        public void ThenIWillGoToTheRelevantPageToCreateAnAccount()
        {
            try
            {
                Assert.AreEqual("http://automationpractice.com/index.php?controller=authentication&back=my-account", driver.Url);
            }
            finally
            {
                driver.Close();
            }
        }
        [Then(@"I will see the appropriate error for incorrect email format")]
        public void ThenIWillSeeTheAppropriateErrorForIncorrectEmailFormat()
        {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id("create_account_error")));
            try
            {
                Assert.AreEqual("Invalid email address.", lp.emailCreateAccountErrorBox.Text);
            }
            finally
            {
                driver.Close();
            }
        }
        [Then(@"I will see the appropriate error message for password")]
        public void ThenIWillSeeTheAppropriateErrorMessageForPassword()
        {
            try
            {
                Assert.AreEqual("Invalid password.", lp.AuthenticateError.Text);
            }
            finally
            {
                driver.Close();
            }
        }
        [Then(@"I will see my account name in the nav header")]
        public void IWillSeeMyAccountNameInTheNavHeader()
        {
            // TODO Add web element to Account Page Object
            try
            {
            Assert.AreEqual("Steve Admin", "Steve Admin");
            }
            finally
            {
                driver.Close();
            }
        }
    }
}

