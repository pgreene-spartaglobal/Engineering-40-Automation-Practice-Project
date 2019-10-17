using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Engineering40AutomationPracticeProject.Pages
{
    class CategoryPage
    {
        // the web driver
        IWebDriver driver;

        // Find and bind the grid view select element
        [FindsBy(How = How.Id, Using = "grid")]
        IWebElement gridElement;

        // Find and bind the list view select element
        [FindsBy(How = How.Id, Using = "list")]
        IWebElement listElement;

        /**
         * Constructor
         * @param driver, the web driver
         */
        public CategoryPage(IWebDriver driver)
        {
            this.driver = driver;
            
            // Page factory for binding elements to instance variables
            PageFactory.InitElements(driver, this); 
        }

        /**
         * Go to the catagory page
         */
        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=3&controller=category");
        }

        /**
         * Click on the grid view element
         */
        public void SelectGridView()
        {
            gridElement.Click();
        }

        /**
         * Click on the list view element
         */
        public void SelectListView()
        {
            listElement.Click();
        }

        /**
         * Checks if the item display is in grid view
         * @return true if the dispaly is in grid view
         */
        public bool IsInGridView()
        {
            string className = gridElement.GetAttribute("class");
            if (className == "selected")
            {
                return true;
            }
            return false;
        }

        /**
         * Checks if the item display is in list view
         * @return true if the dispaly is in list view
         */
        public bool IsInListView()
        {
            string className = listElement.GetAttribute("class");
            if (className == "selected")
            {
                try
                {
                    IWebElement description = driver.FindElement(By.ClassName("product-desc"));
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
