using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class ProductViewPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='send_friend_button']")]
        private IWebElement sendToFriendLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='friend_name']")]
        private IWebElement nameField;

        [FindsBy(How = How.XPath, Using = "//*[@id='friend_email']")]
        private IWebElement emailField;

        [FindsBy(How = How.XPath, Using = "//*[@id='sendEmail']")]
        private IWebElement sendButton;

        [FindsBy(How = How.XPath, Using = ".//*[@id='product']/div[2]/div/div/div/p[1]")]
        private IWebElement sendResult;

        public ProductViewPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_product=1&controller=product");
        }

        public void ClickOnSendToFriend()
        {
            sendToFriendLink.Click();
        }

        public void EnterName()
        {
            nameField.SendKeys("xyz");
        }

        public void EnterInvalidEmail()
        {
            emailField.SendKeys("xyz");
        }

        public void ClickSend()
        {
            sendButton.Click();
        }

        public string GetResultText()
        {
            return sendResult.Text;
        }
    }
}
