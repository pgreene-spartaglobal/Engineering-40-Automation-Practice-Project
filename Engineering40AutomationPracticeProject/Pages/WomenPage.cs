using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class WomenPage: ProductPage
    {
        public WomenPage(IWebDriver driver) : base(driver)
        {
            GoToPage();
        }

        public override void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=3&controller=category");
        }
    }
}
