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


namespace Engineering40AutomationPracticeProject.Pages
{

    public class LoginPage
    {
        IWebDriver driver;
        CreateAccountPage cap = new CreateAccountPage();
        public LoginPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }
        public LoginPage() { }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div[1]/ol/li")]
        public IWebElement AuthenticateError;
        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement passwordField;
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement emailField;
        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement submitLoginButton;
        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement createAccountEmail;
        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement submitCreateButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[1]/ol/li")]
        public IWebElement emailCreateAccountErrorBox;

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
            submitLoginButton.Click();
        }
        public void CiaranLogIn(string email, string password)
        {
            Navigate("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            emailField.SendKeys(email);
            passwordField.SendKeys(password);
            submitLoginButton.Click();
        }
        //This is the method to access the create account page
        public void CreateAccount()
        {
            Navigate("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            createAccountEmail.SendKeys(cap.GenerateName(5));
            submitCreateButton.Click();
        }
    }
        public class LoginStep
        {

        private IWebDriver driver;
        [Given(@"I am on the login page")]
            public void GivenIAmOnTheLoginPage()
            {
                driver = new ChromeDriver();
                LoginPage lp = new LoginPage(driver);
                lp.LogIn();
            }
        }

}
