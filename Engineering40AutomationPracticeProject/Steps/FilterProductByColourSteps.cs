using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Engineering40AutomationPracticeProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Engineering40AutomationPracticeProject
{
    [Binding]
    public class FilterProductByColourSteps
    {
        IWebDriver driver;
        TShirtPage tShirtPage;

        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            tShirtPage = new TShirtPage(driver);
        }

        //[Given(@"I am on the Women Page")]
        //public void GivenIAmOnTheWomenPage()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"I tick the Beige check box")]
        //public void WhenITickTheBeigeCheckBox()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Then(@"the result should be showing items in Beige colour only")]
        //public void ThenTheResultShouldBeShowingItemsInBeigeColourOnly()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [Given(@"I am on the T-Shirt Page")]
        public void GivenIAmOnTheT_ShirtPage()
        {
            tShirtPage.GoToPage();
            //tShirtPage.InitPageElements();
        }


        [When(@"I tick the Orange check box")]
        public void WhenITickTheOrangeCheckBox()
        {
            tShirtPage.ClickOrange();
        }

        [Then(@"the result should be showing items that is available in Orange")]
        public void ThenTheResultShouldBeShowingItemsThatIsAvailableInOrange()
        {
            //check if the first item contain orange
            bool result = tShirtPage.ContainColour(tShirtPage.GetOrangeColourCode(), 0);
            //compare result
            Assert.AreEqual(true, result);
        }



        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
