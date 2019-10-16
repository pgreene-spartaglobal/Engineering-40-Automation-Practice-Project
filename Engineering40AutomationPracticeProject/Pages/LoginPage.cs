using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineering40AutomationPracticeProject.Pages
{
    class LoginPage
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='email']")]
        private IWebElement emailField;
        [FindsBy(How = How.XPath, Using = "//*[@id='passwd']")]
        private IWebElement passwordField;
        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement submitBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[2]/div/div/nav/div[2]/a")]
        private IWebElement signOutBtn;

        

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }

        public void Login()
        {
            emailField.SendKeys("nbalaisyte@spartaglobal.com");
            passwordField.SendKeys("Sparta2020");
            submitBtn.Click();
        }

        public void LogOut()
        {
            signOutBtn.Click();
        }

    }
}

