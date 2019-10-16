using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Engineering40AutomationPracticeProject.Pages
{
    class TShirtPage:ProductPage
    {
        public TShirtPage(IWebDriver driver) : base(driver)
        {
            GoToPage();
        }

        public override void GoToPage()
        {
            base.GoToPage();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=5&controller=category");
        }
    }
}
