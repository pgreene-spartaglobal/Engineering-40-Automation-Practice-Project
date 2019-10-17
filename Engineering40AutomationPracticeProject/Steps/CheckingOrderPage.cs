using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class CheckingOrdersPageSteps
    {
        IWebDriver driver;
        LoginPage lp;
        MyAccountPage map;
        OrderPage op;
        [Given(@"I have logged into the account")]
        public void GivenIHaveLoggedIntoTheAccount()
        {
            driver = new ChromeDriver();
            lp = new LoginPage(driver);
            map = new MyAccountPage(driver);
            op = new OrderPage(driver);
            lp.LogIn();
        }
        
        [Given(@"I have clicked view orders")]
        public void GivenIHaveClickedViewOrders()
        {
            map.orderButton.Click();
        }
        
        [Given(@"I have clicked sort price")]
        public void GivenIHaveClickedSortPrice()
        {
            op.sortButton.Click();
        }
        
        [Given(@"I have clicked view details")]
        public void GivenIHaveClickedViewDetails()
        {
            op.detailsButton.Click();
        }
        
        [Given(@"I have selected the product")]
        public void GivenIHaveSelectedTheProduct()
        {
            //Need to FIX
            op.SelectProduct();
        }
        
        [Given(@"I have wrote a message")]
        public void GivenIHaveWroteAMessage()
        {
            op.textBoxForMessage.SendKeys("Hello, I have an issue.");
        }
        
        [Given(@"I have clicked send")]
        public void GivenIHaveClickedSend()
        {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div/form[2]/div/button")));
            op.sendMailButton.Click();
        }
        
        [Given(@"I have clicked reorder")]
        public void GivenIHaveClickedReorder()
        {
            op.reorderButton.Click();
        }
        
        [Then(@"I should see the orders page")]
        public void ThenIShouldSeeTheOrdersPage()
        {
            try
            {
            Assert.AreEqual("http://automationpractice.com/index.php?controller=history", driver.Url);
            }
            finally
            {
                driver.Close();
            }
        }
        
        [Then(@"The orders should be ordered by price being minimum first")]
        public void ThenTheOrdersShouldBeOrderedByPriceBeingMinimumFirst()
        {
            Assert.AreEqual("AWKZIFJDW", op.orderedByMinTag.Text);
        }
        
        [Then(@"I should be on the correct page for that order")]
        public void ThenIShouldBeOnTheCorrectPageForThatOrder()
        {
            try
            {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div/div[1]/form/p/strong")));
            Assert.AreEqual("Order Reference QBVHVETMA -- placed on 10/17/2019", op.orderReference.Text);
            }
            finally
            {
                driver.Close();
            }

        }
        
        [Then(@"I should see a successful message sent")]
        public void ThenIShouldSeeASuccessfulMessageSent()
        {
            try
            {
                WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div/p")));
                Assert.AreEqual("Message successfully sent", op.successSend.Text);
            }
            finally
            {
                driver.Close();
            }
        }
        
        [Then(@"I should be on the checkout page")]
        public void ThenIShouldBeOnTheCheckoutPage()
        {
            try
            {
            Assert.AreEqual("http://automationpractice.com/index.php?controller=order", driver.Url);
            }
            finally
            {
                driver.Close();
            }
        }
    }
}
