using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineering40AutomationPracticeProject.Pages
{
    class CheckoutPage
    {
        private IWebDriver driver;

        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //[FindsBy(How = How.LinkText, Using = "http://automationpractice.com/index.php?controller=cart&add=1&id_product=1&token=e817bb0705dd58da8db074c69f729fd8")]
        //private IWebElement ButtonAddToCart;

        //public void GoToPage()
        //{
        //    driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=3&controller=category");
        //}

        //public void AddToCardButton()
        //{
        //    ButtonAddToCart.Click();
        //}

        //COSMIN'S TERRITORY! TRESSPASS AT YOUR OWN RISK!
        [FindsBy(How = How.LinkText, Using = "http://automationpractice.com/index.php?controller=cart&add=1&id_product=1&token=e817bb0705dd58da8db074c69f729fd8")]
        private IWebElement AddToCart;

        [FindsBy(How = How.LinkText, Using = "http://automationpractice.com/index.php?controller=order")]
        private IWebElement ProceedToCheckoutAfterBuying;

        [FindsBy(How = How.LinkText, Using = "http://automationpractice.com/index.php?controller=order&amp;step=1")]
        private IWebElement ProceedToCheckOutSummary;

        [FindsBy(How = How.Name, Using = "processAddress")]
        private IWebElement ProceedToCheckOutAddress;

        [FindsBy(How = How.Id, Using = "cgv")]
        private IWebElement CheckBoxShipping;

        [FindsBy(How = How.Name, Using = "processCarrier")]
        private IWebElement ProceedToCheckOutShipping;

        [FindsBy(How = How.LinkText, Using = "http://automationpractice.com/index.php?fc=module&module=bankwire&controller=payment")]
        private IWebElement PayByBankWire;

        [FindsBy(How = How.LinkText, Using = "http://automationpractice.com/index.php?fc=module&module=cheque&controller=payment")]
        private IWebElement PayByCheck;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement userNameFieldSignIn;

        [FindsBy(How = How.Id, Using = "email_create")]
        private IWebElement userNameFieldRegister;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement SignIn;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement CreateAnAccount;

        //Get The Order Confirmation Page for Pay by bank wire
        ////[FindsBy(How = How.Class, Using = "page-heading")]
        ////private IWebElement OrderConfirmationHeading;
        IWebElement OrderConfirmationHeading = driver.FindElement(By.CssSelector("div[class='page-heading']"));

        //Get The Order Confirmation Page for Pay by check
        ////[FindsBy(How = How.Class, Using = "alert alert-success")]
        ////private IWebElement OrderConfirmationAlert;
        IWebElement OrderConfirmationAlert = driver.FindElement(By.CssSelector("div[class='alert alert-success']"));

        //Check if you are on the Create An Account page
        ////[FindsBy(How = How.Class, Using = "page-heading")]
        ////private IWebElement CreateAccountHeading;
        IWebElement CreateAccountHeading = driver.FindElement(By.CssSelector("div[class='page-heading']"));

        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=3&controller=category");
        }
        public void AddToCartButton()
        {
            AddToCart.Click();
        }
        public void ProceedToCheckoutAfterBuyingButton()
        {
            ProceedToCheckoutAfterBuying.Click();
        }
        public void ProceedToCheckOutButtonSummary()
        {
            ProceedToCheckOutSummary.Click();
        }
        public void ProceedToCheckOutButtonAddress()
        {
            ProceedToCheckOutAddress.Click();
        }
        public void CheckBoxButtonShipping()
        {
            CheckBoxShipping.Click();
        }
        public void ProceedToCheckOutButtonShipping()
        {
            ProceedToCheckOutShipping.Click();
        }
        public void PayByBankWireButton()
        {
            PayByBankWire.Click();
        }
        public void PayByCheckButton()
        {
            PayByCheck.Click();
        }
        public void IConfirmMyOrderButton()
        {
            IConfirmMyOrder.Click();
        }
        public void FillUserName(string userName)
        {
            userNameFieldSignIn.SendKeys(userName);
        }
        public void FillPassword(string password)
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

        //methods to get the result text for test
        public string GetTheResult()
        {
            return passwordResult.Text;
        }
    }
}
