using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium.Support.UI;

//no more bugs
namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class CreateAccountSteps
    {
        IWebDriver driver;
        LoginPage lp;
        CreateAccountPage cap;

        [Given(@"I have entered a valid password")]
        public void GivenIHaveEnteredAValidPassword()
        {
            cap.passwordField.SendKeys("Dinosaurs");
        }
        [Given(@"I have not entered a valid password")]
        public void GivenIHaveEnteredAnInvalidPassword()
        {
            cap.passwordField.SendKeys("");
        }

        
        [Given(@"I have entered a valid email address and clicked create account")]
        public void GivenIHaveEnteredAValidEmailAddressAndClickedCreateAccount()
        {
            driver = new ChromeDriver();
            cap = new CreateAccountPage(driver);
            lp = new LoginPage(driver);
            lp.CreateAccount();
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id("customer_firstname")));

        }
        
        [Given(@"I have entered a first name")]
        public void GivenIHaveEnteredAFirstName()
        {
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
        [Given(@"I have clicked create account button")]
        public void GivenIHaveClickedCreateAccountButton()
        {
            lp.submitCreateButton.Click();
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id("customer_firstname")));
        }


        [Given(@"I have not entered a valid mobile phone")]
        public void GivenIHaveNotEnteredAValidMobilePhone()
        {
            cap.mobilephoneField.SendKeys("");
        }
        
        [Given(@"I have not entered a city")]
        public void Ihavenotenteredacity()
        {
            cap.cityField.SendKeys("");
        }
        [Given(@"I have clicked submit information")]
        public void GivenIHaveClickedSubmitInformation()
        {
            cap.submitButton.Click();
        }








        [Then(@"I will see the appropriate error message for first name")]
        public void ThenIWillSeeTheAppropriateErrorMessageForFirstName()
        {
            try
            {
            Assert.AreEqual("firstname is required.", cap.errorBox.Text);
            }
            finally
            {
                driver.Close();
            }
        }
        
        [Then(@"I will see the appropriate error message for last name")]
        public void ThenIWillSeeTheAppropriateErrorMessageForLastName()
        {
            try
            {
            Assert.AreEqual("lastname is required.", cap.errorBox.Text);
            }
            finally
            {
                driver.Close();
            }
        }

        [Then(@"I will see the appropriate error message for address")]
        public void ThenIWillSeeTheAppropriateErrorMessageForAddress()
        {
            try
            {
            Assert.AreEqual("address1 is required.", cap.errorBox.Text);

            }
            finally
            {
                driver.Close();
            }
        }
        //Comment
        [Then(@"I will see the appropriate error message for city")]
        public void ThenIWillSeeTheAppropriateErrorMessageForCity()
        {
            try
            {
            Assert.AreEqual("city is required.", cap.errorBox.Text);

            }
            finally
            {
                driver.Close();
            }
        }

        [Then(@"I will see the appropriate error message for state")]
        public void ThenIWillSeeTheAppropriateErrorMessageForState()
        {
            try
            {
            Assert.AreEqual("This country requires you to choose a State.", cap.errorBox.Text);
            }
            finally
            {
                driver.Close();
            }
        }

        [Then(@"I will see the appropriate error message for postal code")]
        public void ThenIWillSeeTheAppropriateErrorMessageForPostalCode()
        {
            try
            {
                Assert.AreEqual("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", cap.errorBox.Text);
            }
            finally
            {
                driver.Close();
            }

        }

        [Then(@"I will see the appropriate error message for password format")]
        public void ThenIWillSeeTheAppropriateErrorMessageForPasswordFormat()
        {
            try
            {
                Assert.AreEqual("passwd is required.", cap.errorBox.Text);
            }
            finally
            {
                driver.Close();
            }
        }


        [Then(@"I will be redirected to the account page")]
        public void ThenIWillBeRedirectedToTheAccountPage()
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

        [Then(@"I will see the appropriate error message for mobile phone")]
        public void ThenIWillSeeTheAppropriateErrorMessageForMobilePhone()
        {
            try
            {
                Assert.AreEqual("You must register at least one phone number.", cap.errorBox.Text);
            }
            finally
            {
                driver.Close();
            }
        }

        [Then(@"I will see the appropriate error message for all failure")]
        public void ThenIWillSeeTheAppropriateErrorMessageForAllFailure()
        {
            try
            {
                Assert.AreEqual("There are 8 errors", cap.errorBoxNumber.Text);
            }
            finally
            {
                driver.Close();
            }
        }

    }
}
