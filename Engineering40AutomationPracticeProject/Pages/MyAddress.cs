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
        
        [FindsBy(How = How.ClassName, Using = "page-subheading")]
        private IWebElement pagesubHeading;

        [FindsBy(How = How.XPath, Using = "//a[@href='http://automationpractice.com/index.php?controller=address'")]
        private IWebElement AddAddressButton;


        public string GetSubpageHeader()
        {
            return pagesubHeading.Text;
        }

        public void ClickAddressButton()
        {

            AddAddressButton.Click();
        }

    }
}
