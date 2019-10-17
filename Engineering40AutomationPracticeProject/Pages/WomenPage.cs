using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class WomenPage : ProductPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/ul/li[1]/div/div[3]/div[1]/a")]
        protected IWebElement addToWishlistBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='category']/div[2]/div/div/div/div/p")]
        protected IWebElement errorBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/ul/li[1]/div/div[3]/div[2]/a")]
        protected IWebElement compare1stItem;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/ul/li[2]/div/div[3]/div[2]/a")]
        protected IWebElement compare2ndstItem;


        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/ul/li[3]/div/div[3]/div[2]/a")]
        protected IWebElement compare3rdstItem;

        [FindsBy(How = How.ClassName, Using = "compare-form")]
        protected IWebElement compareBtn;


        [FindsBy(How = How.ClassName, Using = "//*[@id='product_comparison']/tbody/tr[2]")]
        protected IWebElement TRcount;

        [FindsBy(How = How.XPath, Using = "//*[@id='layered_price_slider']/a[1]")]
        protected IWebElement rangeSlider;

        [FindsBy(How = How.XPath, Using = " //*[@id='center_column']/ul/p/img ")]
        protected IWebElement bufferImg;
       
        public WomenPage(IWebDriver driver) : base(driver)
        {
            //GoToPage();
        }

        public override void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=3&controller=category");
        }

        public void AddToWishList()
        {
            addToWishlistBtn.Click();
        }

        public string ErrorBox()
        {
            return errorBox.Text;
        }

        public void CompareThreeItems()
        {
            compare1stItem.Click();
            Thread.Sleep(1000);
            compare2ndstItem.Click();
            Thread.Sleep(1000);
            compare3rdstItem.Click();
        }

        public void CompareBtn()
        {
            compareBtn.Click();
        }

        public int CompareInfo()
        {

            return 1;
        }

        public void RangeSlider()
        {
            rangeSlider.Click();

        }

        public bool BufferImg()
        {
            return bufferImg.Displayed;
        }
    }
}
