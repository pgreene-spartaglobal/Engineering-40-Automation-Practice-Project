using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class CheckoutSignInPage
    {
        //COSMIN'S TERRITORY! TRESSPASS AT YOUR OWN RISK!
        private IWebDriver driver;

        public CheckoutSignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Get the Addresses Header straight away if you are signed in.
        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/h1")]
        private IWebElement AddressesHeader;

        //Get the Addresses Header straight away if you are signed in.
        public string AddressesHeaderResult()
        {
            return AddressesHeader.Text;
        }
    }
}
