using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading.Tasks;

namespace Engineering40AutomationPracticeProject.Pages
{

    class CreateAccountPage
    {
        readonly IWebDriver driver;
        public CreateAccountPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement firstNameField;
        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement lastNameField;
        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement passwordField;
        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement addressOneField;
        [FindsBy(How = How.Id, Using = "id_state")]
        public IWebElement stateField;
        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement postalcodeField;
        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement cityField;
        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement mobilephoneField;
        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement submitButton;
        




    }
}
