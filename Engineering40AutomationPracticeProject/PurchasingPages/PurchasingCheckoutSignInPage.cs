using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Engineering40AutomationPracticeProject.Pages
{
    class PurchasingCheckoutSignInPage
    {
        private IWebDriver driver;

        public PurchasingCheckoutSignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Get the Authentication Header
        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/h1")]
        private IWebElement AuthenticationHeader;

        //Get the Addresses Header straight away if you are signed in.
        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/h1")]
        private IWebElement AddressesHeader;

        [FindsBy(How = How.ClassName, Using = "page-heading")]
        private IWebElement CreateAccountHeader;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div[1]/ol/li")]
        private IWebElement InvalidPasswordMessage;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div[1]/ol/li")]
        private IWebElement InvalidEmailMessage;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div[1]/ol/li")]
        private IWebElement AuthenticationFailedMessage;
        
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement userNameFieldSignIn;

        [FindsBy(How = How.Id, Using = "email_create")]
        private IWebElement userNameFieldRegister;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement SignIn;

        [FindsBy(How = How.XPath, Using = "//*[@id='SubmitCreate']")]
        private IWebElement CreateAnAccount;

        public void FillUserNameSignIn(string userName)
        {
            userNameFieldSignIn.SendKeys(userName);
        }
        public void FillUserNameCreate(string userName)
        {
            userNameFieldRegister.SendKeys(userName);
        }
        public void FillPasswordSignIn(string password)
        {
            passwordField.SendKeys(password);
        }
        public void SignInButton()
        {
            SignIn.Click();
        }
        public void CreateAnAccountButton()
        {
            CreateAnAccount.Click();
        }
        //Get the Addresses Header straight away if you are signed in.
        public string AddressesHeaderResult()
        {
            return AddressesHeader.Text;
        }
        //Get the Authentication Header
        public string AuthenticationHeaderResult()
        {
            return AuthenticationHeader.Text;
        }
        public string CreateAccountHeaderResult()
        {
            return CreateAccountHeader.Text;
        }
        public string InvalidPasswordMessageResult()
        {
            return InvalidPasswordMessage.Text;
        }
        public string InvalidEmailMessageResult()
        {
            return InvalidEmailMessage.Text;
        }
        public string AuthenticationFailedMessageResult()
        {
            return AuthenticationFailedMessage.Text;
        }
    }
}
