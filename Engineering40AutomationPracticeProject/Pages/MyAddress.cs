using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;



namespace Engineering40AutomationPracticeProject.Pages
{

    class MyAddress
    {


        private IWebDriver driver;

        public MyAddress(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.ClassName, Using = "page-heading")]
        private IWebElement pagesubHeading;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div/div[1]/ul/li[3]/a")]
        private IWebElement AddNewAddressButton;

        [FindsBy(How = How.ClassName, Using = "page-heading")]
        private IWebElement AddAddressBtnText;

        [FindsBy(How = How.XPath, Using = "//*[@id='columns']/div[1]/a[2]")]
        private IWebElement AccountPageBackBTN;
        public string GetSubpageHeader()
        {
            return pagesubHeading.Text;
        }

        public void ClickNewAddressButton()
        {
            AddNewAddressButton.Click();
        }

        public string GetNewAddressButtonName()
        {
            return AddAddressBtnText.Text;
        }

        public void ClickBackBtnName()
        {
            AccountPageBackBTN.Click();
        }

        public void method()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-addresses");
        }
    }
}
