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
        public DressesPage(IWebDriver driver) : base(driver)
        {
            GoToPage();
        }

        public override void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=8&controller=category");
        }
    }
}
