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
        IWebDriver driver;
        public CreateAccountPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }

        public CreateAccountPage() { }

        public string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "", Name2 = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2;
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }
            while (b < len)
            {
                Name2 += consonants[r.Next(consonants.Length)];
                b++;
                Name2 += vowels[r.Next(vowels.Length)];
                b++;
            }
            return Name + "@" + Name + ".com";
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
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/ol/li")]
        public IWebElement errorBox;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/p")]
        public IWebElement errorBoxNumber;

    }
}
