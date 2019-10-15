using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;


namespace Engineering40AutomationPracticeProject
{

    public class Base
    {
        public IWebDriver driver;
        public Base(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }
        public void SetUp()
        {
            driver = new ChromeDriver();

        }
        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement passwordField;
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement emailField;
        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement submitButton;
        public void Navigate(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        public void LogIn()
        {
            string password = "PAssword";
            string email = "steve@admin.com";
            Navigate("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            emailField.SendKeys(email);
            passwordField.SendKeys(password);
            submitButton.Click();
        }
    }

        [Binding]
        public class LoginStep
        {

        private IWebDriver driver;
        [Given(@"I am on the login page")]
            public void GivenIAmOnTheLoginPage()
            {
                driver = new ChromeDriver();
                Base ba = new Base(driver);
                ba.LogIn();
            }
            [AfterScenario]
            public void DisposeWebDriver()
            {
                driver.Close();
            }
        }

}
