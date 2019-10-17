using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Engineering40AutomationPracticeProject.Pages
{
    public class OrderPage
    {
        IWebDriver driver;
        public OrderPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }
        public OrderPage() { }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div/p")]
        public IWebElement successSend;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/table/tbody/tr[1]/td[1]/a")]
        public IWebElement sortedMinOrderName;
        [FindsBy(How = How.Id, Using = "")]
        public IWebElement def;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/table/tbody/tr[1]/td[1]/a")]
        public IWebElement orderedByMinTag;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div/div[1]/form/p/strong")]
        public IWebElement orderReference;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/table/tbody/tr[1]/td[7]/a[1]")]
        public IWebElement detailsButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/table/thead/tr/th[3]")]
        public IWebElement sortButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div/form[2]/p[2]/select/option[2]")]
        public IWebElement selectProductMenu;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div/form[2]/p[2]/select")]
        public IWebElement selectProdutNumber;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div/form[2]/p[3]/textarea")]
        public IWebElement textBoxForMessage;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div/form[2]/div/button")]
        public IWebElement sendMailButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/table/tbody/tr[1]/td[7]/a[2]")]
        public IWebElement reorderButton;

        public void SelectProduct()
        {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("id_product")));
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Name("id_product")));
            oSelect.SelectByIndex(1);
        }

    }
}
