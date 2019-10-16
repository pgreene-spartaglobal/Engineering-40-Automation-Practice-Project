using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Engineering40AutomationPracticeProject.Pages
{
    class DressesPage: ProductPage
    {
        [FindsBy(How = How.ClassName, Using = "replace-2x img-responsive")]
        private IWebElement clickprintedDress;
        [FindsBy(How = How.ClassName, Using = "btn btn-default btn-twitter")]
        private IWebElement twitter;
        [FindsBy(How = How.ClassName, Using = "btn btn-default btn-facebook")]
        private IWebElement facebook;
        [FindsBy(How = How.ClassName, Using = "btn btn-default btn-google-plus")]
        private IWebElement googleplus;
        [FindsBy(How = How.ClassName, Using = "btn btn-default btn-pinterest")]
        private IWebElement pinterest;
        public DressesPage(IWebDriver driver) : base(driver)
        {
            GoToPage();
        }

        public override void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=8&controller=category");
        }

        public void ClickFacebook()
        {
            facebook.Click();
        }
        public void ClickTwitter()
        {
            twitter.Click();
        }
        public void ClickGooglePlus()
        {
            googleplus.Click();
        }
        public void ClickPinterest()
        {
            pinterest.Click();
        }
    }

    class EveningDresses : ProductPage
    {
        public EveningDresses(IWebDriver driver) : base(driver)
        {

        }

        public override void GoToPage()
        {
            base.GoToPage();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=10&controller=category");
        }
    }

    class SummerDresses : ProductPage
    {
        public SummerDresses(IWebDriver driver) : base(driver)
        {

        }

        public override void GoToPage()
        {
            base.GoToPage();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=11&controller=category");
        }
    }

    class CasualDressesPage : ProductPage
    {
        public CasualDressesPage(IWebDriver driver) : base(driver)
        {

        }

        public override void GoToPage()
        {
            base.GoToPage();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=9&controller=category");
        }
    }
}
