using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium.Support.PageObjects;


namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class AddressEditSteps
    {
        IWebDriver driver;
        LoginPage lp;
        MyAccountPage accountPage;
        MyAddress address;

        [Given(@"I am on the My Accounts Page")]
        public void GivenIAmOnTheMyAccountsPage()
        {
            lp.Navigate("http://automationpractice.com/index.php?controller=my-account");
            accountPage.GetPageHeader();
        }

        [Given(@"I have logged in to see account")]
        public void GivenIHaveLoggedInToSeeAccount()
        {
            driver = new ChromeDriver();
            lp = new LoginPage(driver);
            accountPage = new MyAccountPage(driver);
            address = new MyAddress(driver);
            lp.LogIn();
            accountPage.method();
        }

        [Given(@"I am on the My Addresses Page")]
        public void GivenIAmOnTheMyAddressesPage()
        {
            
            address.ClickNewAddressButton();
            address.GetSubpageHeader();
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I press My Addresses")]
        public void WhenIPressMyAddresses()
        {
            accountPage.ClickMyAddressButton();
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Add new Address Button")]
        public void WhenIPressAddNewAddressButton()
        {
            address.ClickBackBtnName();
            address.GetNewAddressButtonName();
            accountPage.ClickMyAddressButton();
            // ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should See a My Accounts title")]
        public void ThenIShouldSeeAMyAccountsTitle()
        {
            Assert.AreEqual("MY ACCOUNT", accountPage.GetPageHeader());
        }
        
        [Then(@"I should see a My Addresses Button")]
        public void ThenIShouldSeeAMyAddressesButton()
        {
           
            Assert.AreEqual("MY ACCOUNT", address.GetNewAddressButtonName());
            // ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be directed to the My Addresses page")]
        public void ThenIShouldBeDirectedToTheMyAddressesPage()
        {
            Assert.AreEqual("http://automationpractice.com/index.php?controller=addresses", driver.Url);
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see a My Addresses Header")]
        public void ThenIShouldSeeAMyAddressesHeader()
        {
            Assert.AreEqual("MY ADDRESSES", address.GetSubpageHeader());
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to see Add new Address Button")]
        public void ThenIShouldBeAbleToSeeAddNewAddressButton()
        {
            Assert.AreEqual("MY ADDRESSES", address.GetNewAddressButtonName());
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be directed to the Add Address page")]
        public void ThenIShouldBeDirectedToTheAddAddressPage()
        {
            Assert.AreEqual("http://automationpractice.com/index.php?controller=addresses", driver.Url);
           // ScenarioContext.Current.Pending();
        }
        [Scope(Feature = "AddressEdit")]
        [AfterScenario]
        public void DisposeWebDriver()
        {
            driver.Close();
        }
    }
}
