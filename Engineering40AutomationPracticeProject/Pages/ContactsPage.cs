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
    class ContactsPage
    {
        // driver 
        private IWebDriver driver;

        // Send button element
        [FindsBy(How = How.Id, Using = "submitMessage")]
        private IWebElement sendButton;

        // Select subject heading element       
        private SelectElement subjectHeading;

        // Input text field element
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailField;

        // The display text
        [FindsBy(How = How.Id, Using = "message")]
        private IWebElement messageField;

        // Message field element
        [FindsBy(How = How.XPath, Using = ".//*[@id='center_column']//p")]
        private IWebElement displayText;

        /**
         * Constructor
         */
        public ContactsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /**
         * Go to contacts page
         */
        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }

        /**
         * Select a subject heading
         */
        public void SelectSubjectHeading()
        {
            subjectHeading = new SelectElement(driver.FindElement(By.Id("id_contact")));
            subjectHeading.SelectByText("Customer service");
        }

        /**
         * Enter email 
         */
        public void EmailField()
        {
            emailField.SendKeys("aazeez@spartaglobal.com");
        }

        /**
         * Enter message
         */
        public void EnterMessage()
        {
            messageField.SendKeys("Test");
        }

        /**
         * Click send button 
         */
        public void ClickSend()
        {
            sendButton.Click();
        }

        /**
         * Get the displayed text after the message has been sent
         * @return the display text
         */
        public string GetDisplayedMessage()
        {
            return displayText.Text;
        }
    }
}
