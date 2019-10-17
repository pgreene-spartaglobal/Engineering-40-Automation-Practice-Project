using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class PurchasingShoppingCartSummaryPage
    {
        private IWebDriver driver;

        public PurchasingShoppingCartSummaryPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='cart_title']/text()")]
        private IWebElement ShopingCartSummaryHeader;

        [FindsBy(How = How.XPath, Using = "//*[@id='product_1_1_0_227582']/td[5]/input[2]")]
        private IWebElement ShopingCartSummaryQuantity;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/p[2]/a[1]")]
        private IWebElement ProceedToCheckOutSummary;

        public void ProceedToCheckOutButtonSummary()
        {
            ProceedToCheckOutSummary.Click();
        }

        //Get Shoping Cart Summary Header
        public string ShopingCartSummaryHeaderResult()
        {
            return ShopingCartSummaryHeader.Text;
        }

        //Get Quantity
        public int ShopingCartSummaryQuantityResult()
        {
            return Convert.ToInt32(ShopingCartSummaryQuantity.ToString());
        }
    }
}
