using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    abstract class ProductPage
    {
        protected IWebDriver driver;

        //cb as Check Box
        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_7")]
        protected IWebElement cbBeige;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_8")]
        protected IWebElement cbWhite;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_11")]
        protected IWebElement cbBlack;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_13")]
        protected IWebElement cbOrage;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_14")]
        protected IWebElement cbBlue;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_15")]
        protected IWebElement cbGreen;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_16")]
        protected IWebElement cbYellow;

        [FindsBy(How = How.Id, Using = "layered_id_attribute_group_24")]
        protected IWebElement cbPink;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickBiege()
        {
            cbBeige.Click();
        }

        public void ClickWhite()
        {

        }

        public void ClickBlack()
        {

        }

        public void ClickOrange()
        {

        }

        public void ClickBlue()
        {

        }

        public void ClickGreen()
        {

        }

        public void ClickYellow()
        {

        }
    }
}
