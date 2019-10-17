using System;
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
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div[1]/ul/li[4]/a")]
        public IWebElement PersonalInfoButtonXpath;
        
       
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/fieldset/div[1]/div[1]/label/div/span/input")]
        public IWebElement xpathGenderMale;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/fieldset/div[1]/div[2]/label/div/span/input")]
        public IWebElement xpathGenderFemale;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/ul/li[1]/a")]
        public IWebElement xpathBackToAccount;
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
        [FindsBy(How = How.ClassName, Using = "page-heading")]
        public IWebElement CheckLoginChange;

        public string CheckingLoggedOut()
        {
            return CheckLoginChange.Text; //this should be: Create an account
        }

        public void LogOut()
        {
            LogOutButton.Click();
        }

        public void GoBack()
        {
            xpathBackToAccount.Click();
        }
        //this function is how to get to the info page.
        public void GoToInfoPage()
        {
            PersonalInfoButtonXpath.Click();
        }

        //these functions are for checking the personal info page.
        //need help here.
        //we are only checking if its male because of time restrants.
        public string CheckGenderMale()
        {
            string result = xpathGenderMale.GetAttribute("checked");
            return result;
        }
        public string CheckGenderFemale()
        {
            string result = xpathGenderFemale.GetAttribute("checked");
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
        //the save button.
        public void ClickSubmit()
        {
            SubmitButton.Click();
        }
        //hopefully this is for clicking for female.
        public void ChangeGender()
        {
            xpathGenderFemale.Click();
        }
        //we need to clear the info box because if we just send the keys it will just add the old info
        //onto the new one. Maybe this is a bug?
        public void ChangeFirstName(string firstName)
        {
            FirstName.Clear();
            FirstName.SendKeys(firstName);
        }
        public void ChangeLastName(string lastName)
        {
            LastName.Clear();
            LastName.SendKeys(lastName);
        }
        public void ChangeEmailName(string email)
        {
            Email.Clear();
            Email.SendKeys(email);
        }
        public void TypeCurPassword(string pass)
        {
            OldPassword.SendKeys(pass);
        }
        //here we change the old pass with the new pass.
        public void newPassword(string newPass)
        {
            NewPassword.SendKeys(newPass);
            ConfirmPassword.SendKeys(newPass);
        }
    }
}
