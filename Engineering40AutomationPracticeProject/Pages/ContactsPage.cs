using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class ContactsPage
    {
        // driver 
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "submitMessage")]
        private IWebElement sendButton;

        [FindsBy(How = How.Id, Using = "id_contact")]
        private IWebElement selectSubjectHeading;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailField;

        [FindsBy(How = How.Id, Using = "message")]
        private IWebElement messageField;

        /**
         * Constructor
         */
        public ContactsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /**
         * Go to contacts page
         */
        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }

        public void ClickSend()
        {

        }
    }
}
