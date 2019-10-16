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
        [Given(@"I have logged in")]
        public void GivenIHaveLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I pressed my personal information")]
        public void GivenIPressedMyPersonalInformation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see appropriate gender")]
        public void ThenIShouldSeeAppropriateGender()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see appropriate first name")]
        public void ThenIShouldSeeAppropriateFirstName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see appropriate last name")]
        public void ThenIShouldSeeAppropriateLastName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see appropriate email address")]
        public void ThenIShouldSeeAppropriateEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
