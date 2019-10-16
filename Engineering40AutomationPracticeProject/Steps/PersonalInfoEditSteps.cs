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
    public class PersonalInfoEditSteps
    {
        IWebDriver driver;
        LoginPage ba;
        PersonalInfoPage personalInfoPage;
        //loggin in part of test.
        [Given(@"I have logged in")]
        public void GivenIHaveLoggedIn()
        {
            driver = new ChromeDriver();
            ba = new LoginPage(driver);
            personalInfoPage = new PersonalInfoPage(driver);
            ba.LogIn();
        }

        [Given(@"I pressed my personal information")]
        public void GivenIPressedMyPersonalInformation()
        {
            personalInfoPage.GoToInfoPage();
        }
        //checking infomation part of test.
        [Then(@"I should see appropriate gender")]
        public void ThenIShouldSeeAppropriateGender()
        {
            string result = personalInfoPage.CheckGender();
            StringAssert.Contains(result, "true");
        }

        [Then(@"I should see appropriate first name")]
        public void ThenIShouldSeeAppropriateFirstName()
        {
            string result = personalInfoPage.CheckFirstName();
            StringAssert.Contains(result, "Ac");
        }

        [Then(@"I should see appropriate last name")]
        public void ThenIShouldSeeAppropriateLastName()
        {
            string result = personalInfoPage.CheckLastName();
            StringAssert.Contains(result, "bc");
        }

        [Then(@"I should see appropriate email address")]
        public void ThenIShouldSeeAppropriateEmailAddress()
        {
            string result = personalInfoPage.CheckEmail();
            StringAssert.Contains(result, "a@b.a");
        }
        //changing of information of test.
        [Given(@"I entered my new first name")]
        public void GivenIEnteredMyNewFirstName()
        {
            ScenarioContext.Current.Pending();
        }
        [Given(@"I entered my new last name")]
        public void GivenIEnteredMyNewLastName()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I entered my new email address")]
        public void GivenIEnteredMyNewEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have entered my current password")]
        public void GivenIHaveEnteredMyCurrentPassword()
        {
            ScenarioContext.Current.Pending();
        }
        //navigation part of test.
        [Given(@"I pressed the save button")]
        public void GivenIPressedTheSaveButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I back on my account")]
        public void GivenIBackOnMyAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        //check new values of test.
        
        [Then(@"I should see the new first name")]
        public void ThenIShouldSeeTheNewFirstName()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"I should see the new last name")]
        public void ThenIShouldSeeTheNewLastName()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the new email address")]
        public void ThenIShouldSeeTheNewEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
