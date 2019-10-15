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
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div[1]/ol/li")]
        public IWebElement AuthenticateError;
        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement passwordField;
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement emailField;
        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement submitButton;
        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement createAccountEmail;


        //This is the method to navigate easily during the tests
        public void Navigate(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        /*(This is the base login method for other testers to use
         * This has the correct email and password to login
         * It also navigates to the login page by default                 
         */
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
