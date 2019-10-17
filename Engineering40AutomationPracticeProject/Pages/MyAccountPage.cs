using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;



namespace Engineering40AutomationPracticeProject.Pages
{
    class MyAccountPage
    {
        private IWebDriver driver;
        
        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "page-heading")]
        private IWebElement pageHeading;

        [FindsBy(How = How.ClassName, Using = "icon-building")]
        private IWebElement MyAddressButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div[1]/ul/li[1]/a")]
        public IWebElement orderButton;

        [FindsBy(How = How.ClassName, Using = "account")]
        private IWebElement MyAccountButton;
        public void ClickMyAddressButton()
        {
            MyAddressButton.Click();
        }

        public string GetPageHeader()
        {
            return pageHeading.Text;
        }

        public string GetAccountHeader()
        {
            return MyAccountButton.Text;
        }
    }
   
        
}
    



