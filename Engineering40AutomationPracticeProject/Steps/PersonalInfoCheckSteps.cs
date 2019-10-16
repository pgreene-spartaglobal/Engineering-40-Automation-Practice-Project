using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using Engineering40AutomationPracticeProject.Pages;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class PersonalInfoCheckSteps
    {
        IWebDriver driver;
        LoginPage ba;
        PersonalInfoPage personalInfoPage;
        //no clue why we need to of these the syntax is the same for both thingys.
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
        
        [Then(@"I should see appropriate gender")]
        public void ThenIShouldSeeAppropriateGender()
        {
            string result = personalInfoPage.CheckGender();// Denpends on how we can check gender.
            StringAssert.Contains(result, "Checked");
        }
        
        [Then(@"I should see appropriate first name")]
        public void ThenIShouldSeeAppropriateFirstName()
        {
            string result = personalInfoPage.CheckFirstName();
            StringAssert.Contains(result, "Steve");
        }
        
        [Then(@"I should see appropriate last name")]
        public void ThenIShouldSeeAppropriateLastName()
        {
            string result = personalInfoPage.CheckLastName();
            StringAssert.Contains(result, "Admin");
        }
        
        [Then(@"I should see appropriate email address")]
        public void ThenIShouldSeeAppropriateEmailAddress()
        {
            string result = personalInfoPage.CheckEmail();
            StringAssert.Contains(result, "steve@admin.com");
        }
    }
}
