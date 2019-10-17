using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Engineering40AutomationPracticeProject.Pages
{
    class SpecialOfferPage 
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ".//*[@id='center_column']/ul/li[1]/div/div[2]/div[1]/span[2]")]
        private IWebElement OriginalPrice;
        [FindsBy(How = How.XPath, Using = ".//*[@id='center_column']/ul/li[1]/div/div[2]/div[1]/span[1]")]
        private IWebElement SpecialOfferPrice;
        private char[] number;

        private bool validSpecialPrice = false;


        public SpecialOfferPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=prices-drop");
        }


        
        public void ComparePrice()
        {
            if (double.Parse(SpecialOfferPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat) < double.Parse(OriginalPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat))
            {
                validSpecialPrice = true; 
            }
        }

        public bool checkSpecialPriceValidity()
        {
            return validSpecialPrice;
        }


        

    }
}
