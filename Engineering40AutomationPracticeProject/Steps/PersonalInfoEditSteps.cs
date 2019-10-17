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
            ba.CiaranLogIn("a@b.a","ababa");
        }

        [Given(@"I pressed my personal information")]
        public void GivenIPressedMyPersonalInformation()
        {
            personalInfoPage.GoToInfoPage();
        }
        [Given(@"I have logged in to new email")]
        public void GivenIHaveLoggedInToNewEmail()
        {
            driver = new ChromeDriver();
            ba = new LoginPage(driver);
            personalInfoPage = new PersonalInfoPage(driver);
            ba.CiaranLogIn("new@email.new", "ababa");
        }

        [Given(@"I entered my old email address")]
        public void GivenIEnteredMyOldEmailAddress()
        {
            personalInfoPage.ChangeEmailName("a@b.a");
        }

        //checking infomation part of test.
        [Then(@"I should see appropriate gender")]
        public void ThenIShouldSeeAppropriateGender()
        {
            string result = personalInfoPage.CheckGenderMale();
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
        [Then(@"I should see the old email address")]
        public void ThenIShouldSeeTheOldEmailAddress()
        {
            string result = personalInfoPage.CheckEmail();
            StringAssert.Contains(result, "a@b.a");
        }

        //changing of information of test.
        [Given(@"I entered my new first name")]
        public void GivenIEnteredMyNewFirstName()
        {
            personalInfoPage.ChangeFirstName("newFirstName");
        }
        [Given(@"I entered my new last name")]
        public void GivenIEnteredMyNewLastName()
        {
            personalInfoPage.ChangeLastName("newLastName");
        }

        [Given(@"I entered my new email address")]
        public void GivenIEnteredMyNewEmailAddress()
        {
            personalInfoPage.ChangeEmailName("new@email.new");
        }
        [Given(@"I entered my new gender")]
        public void GivenIEnteredMyNewGender()
        {
            personalInfoPage.ChangeGender();
        }


        [Given(@"I have entered my current password")]
        public void GivenIHaveEnteredMyCurrentPassword()
        {
            personalInfoPage.TypeCurPassword("ababa");
        }
        //navigation part of test.
        [Given(@"I pressed the save button")]
        public void GivenIPressedTheSaveButton()
        {
            personalInfoPage.ClickSubmit();
        }
        
        [Given(@"I back on my account")]
        public void GivenIBackOnMyAccount()
        {
            personalInfoPage.GoBack();
        }
        
        //check new values of test.
        //first name the first letter becomes a captial even if you dont input it as such.
        //and it uncaps every other letter. this doesnt happen to the last name.
        [Then(@"I should see the new first name")]
        public void ThenIShouldSeeTheNewFirstName()
        {
            string result = personalInfoPage.CheckFirstName();
            StringAssert.Contains(result, "Newfirstname");
        }
        [Then(@"I should see the new last name")]
        public void ThenIShouldSeeTheNewLastName()
        {
            string result = personalInfoPage.CheckLastName();
            StringAssert.Contains(result, "newLastName");
        }

        [Then(@"I should see the new email address")]
        public void ThenIShouldSeeTheNewEmailAddress()
        {
            string result = personalInfoPage.CheckEmail();
            StringAssert.Contains(result, "new@email.new");
        }
        [Then(@"I should see my new gender")]
        public void ThenIShouldSeeMyNewGender()
        {
            string result = personalInfoPage.CheckGenderFemale();
            StringAssert.Contains(result, "true");
        }
        //changing password tests
        [Given(@"i have entered my new password")]
        public void GivenIHaveEnteredMyNewPassword()
        {
            personalInfoPage.newPassword("avava");
        }
        [Given(@"i have logged out")]
        public void GivenIHaveLoggedOut()
        {
            personalInfoPage.LogOut();
        }
        [Given(@"I have logged in with new pass")]
        public void GivenIHaveLoggedInWithNewPass()
        {
            ba.CiaranLogIn("a@b.a", "avava");
        }
        [Then(@"i should see the logged in page")]
        public void ThenIShouldSeeTheLoggedInPage()
        {
            string result = personalInfoPage.CheckingLoggedOut();
            StringAssert.Contains(result, "MY ACCOUNT");
        }
    }
}
