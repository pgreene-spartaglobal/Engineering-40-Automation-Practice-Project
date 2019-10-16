﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class CasualDressesPage:ProductPage
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
