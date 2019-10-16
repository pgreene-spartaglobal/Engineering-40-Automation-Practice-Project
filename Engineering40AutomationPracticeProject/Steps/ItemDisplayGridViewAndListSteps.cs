using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Engineering40AutomationPracticeProject.Pages;

namespace Engineering40AutomationPracticeProject.Steps
{
    [Binding]
    public class ItemDisplayGridViewAndListSteps
    {

        IWebDriver chromeDriver;
        CategoryPage categoryPage;

        [Scope(Feature = "ItemDisplayGridViewAndList")]
        [BeforeScenario]
        public void SetUp()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();
            categoryPage = new CategoryPage(chromeDriver);
        }

        [Given(@"I am in the Category page")]
        public void GivenIAmInTheCategoryPage()
        {
            categoryPage.GoToPage();
        }
        
        [When(@"I click on the grid view option")]
        public void WhenIClickOnTheGridViewOption()
        {
            categoryPage.SelectGridView();
        }
        
        [When(@"I click on the list view option")]
        public void WhenIClickOnTheListViewOption()
        {
            categoryPage.SelectListView();
        }
        
        [Then(@"The items should be displayed in grid view")]
        public void ThenTheItemsShouldBeDisplayedInGridView()
        {
            Assert.IsTrue(categoryPage.IsInGridView());
        }
        
        [Then(@"The items should be displayed in list view")]
        public void ThenTheItemsShouldBeDisplayedInListView()
        {
            Assert.IsTrue(categoryPage.IsInListView());
        }

        [Scope(Feature = "ItemDisplayGridViewAndList")]
        [AfterScenario]
        public void CleanUp()
        {
            chromeDriver.Close();
        }
    }
}
