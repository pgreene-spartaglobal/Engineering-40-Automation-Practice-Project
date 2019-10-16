﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections;
using System.Threading;

namespace Engineering40AutomationPracticeProject.Pages
{
    class PersonalInfoPage
    {
        public IWebDriver driver;
        public PersonalInfoPage() { }
        public PersonalInfoPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[@href='http://automationpractice.com/index.php?controller=identity'")]
        public IWebElement PersonalInfoButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div[1]/ul/li[4]/a")]
        public IWebElement PersonalInfoButtonXpath;

        //This wont work because there are two buttons of this name, dont know how to check which one is selected.
        [FindsBy(How = How.ClassName, Using = "btn btn-default button button-small")]
        public IWebElement goBackToAccountButton;
       
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/fieldset/div[1]/div[1]/label/div/span/input")]
        public IWebElement xpathGenderMale;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/fieldset/div[1]/div[2]/label/div/span/input")]
        public IWebElement xpathGenderFemale;
        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement FirstName;
        [FindsBy(How = How.Id, Using = "lastname")]
        public IWebElement LastName;
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email;
        [FindsBy(How = How.Id, Using = "old_passwd")]
        public IWebElement OldPassword;
        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement NewPassword;
        [FindsBy(How = How.Id, Using = "confirmation")]
        public IWebElement ConfirmPassword;
        [FindsBy(How = How.Name, Using = "submitIdentity")]
        public IWebElement SubmitButton;
        //is class the same as class name? IE: class="logout"
        [FindsBy(How = How.ClassName, Using = "logout")]
        public IWebElement LogOutButton;
        [FindsBy(How = How.ClassName, Using = "page-subheading")]
        public IWebElement CheckLogedOut;

        public string CheckingLoggedOut()
        {
            
            return CheckLogedOut.Text; //this should be: Create an account
        }

        public void LogOut()
        {
            LogOutButton.Click();
        }

        public void GoBack()
        {
            goBackToAccountButton.Click();
        }
        //this function is how to get to the info page.
        public void GoToInfoPage()
        {
            PersonalInfoButtonXpath.Click();
        }

        //these functions are for checking the personal info page.
        //need help here.
        //we are only checking if its male because of time restrants.
        public string CheckGender()
        {
            string result = xpathGenderMale.GetAttribute("checked");
            return result;
        }
        //i dont know how to get: value="firstname"
        public string CheckFirstName()
        {
            return FirstName.GetAttribute("value");
        }
        public string CheckLastName()
        {
            return LastName.GetAttribute("value");
        }
        public string CheckEmail()
        {
            return Email.GetAttribute("value");
        }

        public void ClickSubmit()
        {
            SubmitButton.Click();
        }
        //these functions are for changing the personal info page.
        //the change gender ill need help with.
        public void ChangeGender()
        {

        }
        public void ChangeFirstName(string firstName)
        {
            FirstName.SendKeys(firstName);
        }
        public void ChangeLastName(string lastName)
        {
            LastName.SendKeys(lastName);
        }
        public void ChangeEmailName(string email)
        {
            Email.SendKeys(email);
        }
        //here we change the old pass with the new pass.
        public void ChangePassword(string oldPass, string newPass)
        {
            OldPassword.SendKeys(oldPass);
            NewPassword.SendKeys(newPass);
            ConfirmPassword.SendKeys(newPass);
        }
    }
}
