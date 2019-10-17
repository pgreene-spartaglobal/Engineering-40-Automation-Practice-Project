using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineering40AutomationPracticeProject.Pages
{
    class HomePage
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='block_top_menu']/ul/li[1]/a")]
        private IWebElement womenBtn;
        [FindsBy(How = How.XPath, Using = "//*[@id='block_top_menu']/ul/li[2]/a")]
        private IWebElement dressesBtn;
        [FindsBy(How = How.XPath, Using = "//*[@id='block_top_menu']/ul/li[3]/a")]
        private IWebElement tShirtsBtn;
        [FindsBy(How = How.XPath, Using = "//*[@id='block_various_links_footer']/ul/li[1]/a")]
        private IWebElement specials;
        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[1]/div/div/a/img")]
        private IWebElement mainBannerLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='homefeatured']/li[1]/div/div[1]/div/a[1]")]
        private IWebElement productElement;
         
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        public void WomenTab()
        {
            womenBtn.Click();
            //driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[1]/a")).Click();
        }

        public void DressesTab()
        {
            dressesBtn.Click();
        }
        
        public void TShirtTab()
        {
            tShirtsBtn.Click();           
        }

        /**
         * Click on the specials link
         */
        public void Special()
        {
            specials.Click();
            
        }
        public string SpecialUrl()
        {
            return driver.Url;
        }

        public void BannerClick()
        {
            mainBannerLink.Click();
        }

        public void ClickOnProduct()
        {
            productElement.Click();
        }
    }
}
